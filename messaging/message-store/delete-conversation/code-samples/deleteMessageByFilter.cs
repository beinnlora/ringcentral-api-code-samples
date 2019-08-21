// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string extensionId = "<ENTER VALUE>";
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
DeleteMessageByFilterParameters deleteMessageByFilterParameters = new DeleteMessageByFilterParameters {
    //conversationId = new[] { string },
    //dateTo = "<ENTER VALUE>",
    //type = 'All'
};

RestClient rc = new RestClient(
    Environment.GetEnvironmentVariable("clientId"),
    Environment.GetEnvironmentVariable("clientSecret"),
    false
);
await rc.Authorize(
    Environment.GetEnvironmentVariable("username"),
    Environment.GetEnvironmentVariable("extension"),
    Environment.GetEnvironmentVariable("password")
);
var r = await rc.Restapi().Account(accountId).Extension(extensionId).MessageStore().Delete(deleteMessageByFilterParameters);
// PROCESS RESPONSE