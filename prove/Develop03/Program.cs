using System;
class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("2 Nephi", 4, 34);
        Scripture scripture = new Scripture(reference,"O Lord, I have trusted in thee, and I will trust in thee forever. I will not put my trust in the arm of flesh; for I know that cursed is he that putteth his trust in the arm of flesh. Yea, cursed is he that putteth his trust in man or maketh flesh his arm." );

        Console.WriteLine(" ");
        Console.WriteLine($"Reference: {scripture.GetDisplayText()}");
        Console.WriteLine(" ");

        while (!scripture.AllWordsHidden())
        {
            Console.WriteLine("Press enter to hide words and continue or write 'quit' to finish");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }
        
            scripture.HideRandomWords();

            Console.Clear();
            Console.WriteLine($"Reference: {scripture.GetDisplayText()}");
        }
        Console.WriteLine(" ");
        Console.WriteLine("All the words has been hidden. End of the program");
        Console.WriteLine(" ");
    }
}