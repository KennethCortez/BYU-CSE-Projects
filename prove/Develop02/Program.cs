using System;
using System.ComponentModel.Design;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        List<string> questions = new List<string>
        {
            "What is something i could be grateful for?",
            "What was the best time today?",
            "How I felt the spirit today?",
            "Did I do any good today?",
            "How do I feel now?",
            "What is someting i could do better?"
        };

        List<string> journalEntries = new List<string>();

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
            //second option
            else if (menu == "2")
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
            //third option
            else if (menu == "3")
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
            //fourth option
            else if (menu == "4")
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
            //invalid option
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

        //these are some questions i wrote, but i got confused, so i just coment that to remember :)
        //questions.Add("What is something i could be grateful for?");
        //questions.Add("What was the best time today?");
        //questions.Add("How I felt the spirit today?");
        //questions.Add("Did I do any good today?");
        //questions.Add("How do I feel now?");
        //questions.Add("What is someting i could do better?");

        //Also just to keep in mind, kenneth you can add some thins like a message telling 
        //when a journal is empty or a verification that the user created correctly the .txt file