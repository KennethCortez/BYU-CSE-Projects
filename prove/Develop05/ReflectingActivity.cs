public class ReflectingActivity : Activity
{
    private List<string> _questions = new List<string>()
    {
        "Think of a time when you helped someone - how did it make you feel?",
        "Recall a time when you overcame a major challenge - how did it make you feel?",
        "Reflect on an experience that made you feel grateful."
    };

    public ReflectingActivity(int duration)
        :base("Reflecting Activity", "This activity invites you to ponder about positive experiences", duration)
        {}

    public override void Run()
    {
        DisplayStartingMessage();

        string randomQuestion = GetRandomQuestion();
        Console.WriteLine("Ponder about this question: ");
        Console.WriteLine($"--- {randomQuestion} ---");

        Console.WriteLine("\nPress 'Enter' when you're ready to return to the menu.");
        Console.ReadLine();

        DisplayEndingMessage();
    }

    private string GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }
}