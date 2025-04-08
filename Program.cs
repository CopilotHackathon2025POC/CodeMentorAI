using System;
using System.Threading.Tasks;


namespace CodeMentorAI
{
   class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Smart Code Review Agent with GitHub Copilot Integration");

        // Initialize webhook handler
        WebhookHandler webhookHandler = new WebhookHandler();
        
        // Simulate listening for pull request events
        Console.WriteLine("Listening for pull request events...");
        await webhookHandler.HandlePullRequestEvent();
    }
}

}
