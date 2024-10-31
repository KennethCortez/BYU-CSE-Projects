using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Create a Goal");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Record an Event");
            Console.WriteLine("5. Display Player Info");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Exit");
            Console.Write("Option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;
                case "2":
                    goalManager.ListGoalNames();
                    break;
                case "3":
                    goalManager.ListGoalDetails();
                    break;
                case "4":
                    goalManager.RecordEvent();
                    break;
                case "5":
                    goalManager.DisplayPlayerInfo();
                    break;
                case "6":
                    goalManager.SaveGoals();
                    break;
                case "7":
                    goalManager.LoadGoals();
                    break;
                case "8":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
            Console.WriteLine();
        }

        Console.WriteLine("Thank you for using the Goal Tracker!");
    }
}
