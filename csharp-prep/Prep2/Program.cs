using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter your grade percentage:");
        string percent = Console.ReadLine();
        int grade = int.Parse(percent);

        string letter = ""; 

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";     
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (grade >= 80)
        {
            Console.WriteLine("Congraulations, Well done!");
        }
        else
        {
            Console.WriteLine("You did it very well, buy you can improve");
        }
    }
}