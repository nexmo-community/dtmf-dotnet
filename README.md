# Project Name

<img src="https://developer.nexmo.com/assets/images/Vonage_Nexmo.svg" height="48px" alt="Nexmo is now known as Vonage" />

<!-- Add a paragraph about the project. What does it do? Who is it for? Is it actively supported? Your reader just clicked on a random link from another web page and has no idea what Nexmo is ... -->

## Welcome to Vonage

If you're new to Vonage, you can [sign up for a Vonage API account](https://dashboard.nexmo.com/sign-up?utm_source=DEV_REL&utm_medium=github&utm_campaign=dtmf-dotnet) and get some free credit to get you started.

## Prerequisites

## Prerequisites

* A Vonage API account. if you don't have on you can sign up [here](https://dashboard.nexmo.com/sign-up)
* The nexmo CLI. If you don't have it you can install it with `npm install nexmo-cli -g`
* The latest [.NET Core SDK](https://dotnet.microsoft.com/download)
* Visual Studio or Visual Studio Code. I use Visual Studio 2019
* [ngrok](https://ngrok.com/) for testing. You only need the free tier.
* A Voice enabled Vonage Application and Number read the [Getting Started Materials] for more detail

## Test the application

Run ngrok with `ngrok http 5000`, set your applications answer url to https://YOUR_NGROK_URL/webhooks/answer

Run the application with `dotnet run`

You can now test the application by dialing into the number linked to the Vonage Voice Application you set up.

## Getting Help

We love to hear from you so if you have questions, comments or find a bug in the project, let us know! You can either:

* Open an issue on this repository
* Tweet at us! We're [@VonageDev on Twitter](https://twitter.com/VonageDev)
* Or [join the Vonage Developer Community Slack](https://developer.nexmo.com/community/slack)

## Further Reading

* Check out the Developer Documentation at <https://developer.nexmo.com>

<!-- add links to the api reference, other documentation, related blog posts, whatever someone who has read this far might find interesting :) -->

