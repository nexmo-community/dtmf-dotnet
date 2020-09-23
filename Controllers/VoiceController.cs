using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Vonage.Utility;
using Vonage.Voice.EventWebhooks;
using Vonage.Voice.Nccos;

namespace VonageDtmf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoiceController : ControllerBase
    {
        [Route("/webhooks/answer")]
        [HttpGet]
        public ActionResult Answer()
        {
            var responseUrl = $"{Request.Scheme}://{Request.Host}/webhooks/dtmf";
            var talkAction = new TalkAction
            {
                Text = "Hello please enter a digit.",
                BargeIn = "true"
            };
            var inputAction = new MultiInputAction
            {
                Dtmf = new DtmfSettings { MaxDigits = 1 },
                EventUrl = new[] { responseUrl },
                EventMethod = "POST"
            };
            var ncco = new Ncco(talkAction, inputAction);
            return Ok(ncco.ToString());
        }

        [Route("/webhooks/dtmf")]
        [HttpPost]
        public async Task<ActionResult> Dtmf()
        {
            var input = await WebhookParser.ParseWebhookAsync<MultiInput>
                (Request.Body, Request.ContentType);
            var talkAction = new TalkAction
            {
                Text = $"Thank you for inputing: {input.Dtmf.Digits}"
            };
            var ncco = new Ncco(talkAction);
            return Ok(ncco.ToString());
        }
    }
}
