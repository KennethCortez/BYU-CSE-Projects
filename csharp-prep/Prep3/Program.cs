using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number i am thinking? ");
        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != number)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine("Higher, try again");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower, try again");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}