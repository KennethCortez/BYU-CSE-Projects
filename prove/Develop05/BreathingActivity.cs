public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base("Breathing activity", "this activity will help you calm yourself while you slowly inhale and exhale", duration)
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        int remainingTime = Duration;
        while (remainingTime > 0)
        {
            Console.WriteLine($"Inhale.");
            ShowCountDown(3);
            remainingTime -= 3;

            if (remainingTime > 0)
            {
                Console.WriteLine($"Exhale.");
                ShowCountDown(3);
                remainingTime -= 3;
            }
        }
        DisplayEndingMessage();
    }
}