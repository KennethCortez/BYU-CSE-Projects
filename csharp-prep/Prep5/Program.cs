using System;

class Program
{
    static void Main(string[] args)
    {
        string userName = askUserName();
        SayHello(userName);

        int userNumber = askUserNumber();

        int squaredNumber = SquaredNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void SayHello(string name)
    {
        Console.Write("Hello there, wanna see something cool? ");
        string answer = Console.ReadLine();

        if (answer.ToLower() == "yes")
        {
            Console.Write($"Lets Go!, {name}");
        }
        else
        {
            Console.Write($"ahhh, well I don't care {name}");
        }
    }   

    static string askUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int askUserNumber()
    {
        Console.Write(" , now enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquaredNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"hey, {name}, the square of your number is {square} ");
    }
}