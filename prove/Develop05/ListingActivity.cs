public class ListingActivity : Activity
{
    private List<String> _prompts = new List<string>()
    {
        "What makes you happiest in life?",
        "What Things make you feel grateful?",
        "What accomplishments have you had recently?",
        "What goals would you like to achieve"
    };

    public ListingActivity(int duration)
    : base("Listing Activity", "This activity invites you to make a list of positive things", duration)
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        string randomPrompt = GetRandomPrompt();
        Console.WriteLine("Please take your time to ponder and respond;:");
        Console.WriteLine();
        Console.WriteLine($"--- {randomPrompt} ---");
        Console.WriteLine("Write as many responses you can. When you're done, type 'Done' to finish.");

        List<string> responses = GetListFromUser();

        Console.WriteLine($"You have wrote {responses.Count} responses.");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    private List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (true)
        {
            string response = Console.ReadLine();
            if (response.ToLower() == "done")
            {
                break;
            }
            else if (!string.IsNullOrEmpty(response))
            {
                responses.Add(response);
            }
        }
        return responses;
    }
}