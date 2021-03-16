using System;

public static void Run(TimerInfo myTimer, ILogger log)
{
    log.LogInformation($"TEST REDEPLOYMENT!C# Timer trigger function executed at: {DateTime.Now}");
}
