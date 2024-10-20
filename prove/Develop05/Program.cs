class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How long do you want this activity to last? (in seconds)");
        int duration = int.Parse(Console.ReadLine());

        BreathingActivity breathingActivity = new BreathingActivity(duration);
        ReflectingActivity reflectingActivity = new ReflectingActivity(duration);
        ListingActivity listingActivity = new ListingActivity(duration);

        while (true)
        {
            //This is the menu
            Console.WriteLine("");
            Console.WriteLine("Choose one mindfulness activity ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    breathingActivity.Run();
                    break;
                case "2":
                    reflectingActivity.Run();
                    break;
                case "3":
                    listingActivity.Run();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid selection try again.");
                    break;
            }
        }
    }
}