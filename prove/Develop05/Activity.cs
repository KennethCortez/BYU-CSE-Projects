public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public string Name => _name;
    public string Description => _description;
    public int Duration => _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting the {_name}");
        Console.WriteLine(_description);
        Console.WriteLine($"Duration: {_duration} seconds");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Great job you had completed the {_name}");
        Console.WriteLine($"Total duration {_duration} seconds");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            System.Threading.Thread.Sleep(300);
            Console.Write("\b \b");

            Console.Write("∖");
            System.Threading.Thread.Sleep(300);
            Console.Write("\b \b");

            Console.Write("-");
            System.Threading.Thread.Sleep(300);
            Console.Write("\b \b");
            
            Console.Write("/");
            System.Threading.Thread.Sleep(300);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i} ");
            System.Threading.Thread.Sleep(1000);
        }
        Console.Write("\r ");
    }
    public abstract void Run();
}