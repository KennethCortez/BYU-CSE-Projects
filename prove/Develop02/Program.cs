using System;
using System.ComponentModel.Design;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        Console.WriteLine ("Hi there, what do you want to do?");
        Console.WriteLine ("1. Write some thoughts");
        Console.WriteLine ("2. Display your currently entries");
        Console.WriteLine ("3. Load your journal (please notice that you have to write .txt after the name of your file)");
        Console.WriteLine ("4. Save (please notice that you have to write .txt after the name of your file)");
        Console.WriteLine ("5. Quit");
        Console.WriteLine (" ");
        String menu = Console.ReadLine ();

        while (menu != "5")
        {
            if (menu == "1")
            {
                journal.WriteEntry();
            }
            else if (menu == "2")
            {
                journal.DisplayEntries();
            }
            else if (menu == "3")
            {
                journal.LoadEntries();
            }
            else if (menu == "4")
            {
                journal.SaveEntries();
            }
            else
            {
                Console.WriteLine ("invalid option, lets try again");
            }

            Console.WriteLine (" ");
            Console.WriteLine ("What do you want to do now?");
            Console.WriteLine ("1. Write some thoughts");
            Console.WriteLine ("2. Display your currently entries");
            Console.WriteLine ("3. Load your journal (please notice that you have to write .txt after the name of your file)");
            Console.WriteLine ("4. Save (please notice that you have to write .txt after the name of your file)");
            Console.WriteLine ("5. Quit");
            Console.WriteLine (" ");
            menu = Console.ReadLine ();
        }
        Console.WriteLine ("Goodbye!");
    }
}    

class Journal
{
    private List<string> questions = new List<string>
    {
        "What is something i could be grateful for?",
        "What was the best time today?",
        "How I felt the spirit today?",
        "Did I do any good today?",
        "How do I feel now?",
        "What is someting i could do better?"
    };
    private List<string> journalEntries = new List<string>();
    public void WriteEntry()
    {
        Random random = new Random();
            int index = random.Next(questions.Count);
            string selectedQuestion = questions[index];

            Console.WriteLine(selectedQuestion);
            string userInput = Console.ReadLine();

            string date = DateTime.Now.ToString("ddd MMM d HH:mm yyyy");
            String entry = $"{date} - Question: {selectedQuestion} - Response: {userInput}";

            journalEntries.Add(entry);
            Console.WriteLine ("Your responde has been recorded");
    }
    public void DisplayEntries()
    {
        if (journalEntries.Count == 0)
        {
            Console.WriteLine ("Here are your entries");
        }
        else
        {
            Console.WriteLine ("Here are your entries: ");
            foreach (string entry in journalEntries)
            {
                Console.WriteLine (entry);
            }
        }
    }
    public void LoadEntries()
    {
        Console.WriteLine ("Please enter the filename to load your journal: ");
        string filename = Console.ReadLine();

        try
        {
            journalEntries.Clear();

            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    journalEntries.Add(line);
                }
            }
            Console.WriteLine("Your journal has been loaded successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading the journal: {ex.Message}");
        }
    }

    public void SaveEntries()
    {
        Console.WriteLine ("Please enter the filename to save your journal");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (string entry in journalEntries)
                {
                    writer.WriteLine(entry);
                }
            }
            Console.WriteLine ("Your journal has been saved successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine ($"An error ocurred while saving the journal: {ex.Message}");
        }
    }
}
        //Well i just notices that i did not created class, i just did the code without so i created the Journal class and its methods and behaviors
        //so now its little bit different, but better

        //Also just to keep in mind, kenneth you can add some thins like a message telling 
        //when a journal is empty or a verification that the user created correctly the .txt file
