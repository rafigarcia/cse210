using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
               
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        bool error = false;    
                
         while (true)
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Press enter or type 'quit' to finish:");
            }
            else
            {
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                if (error)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please try again.");
                    Console.ResetColor();
                    error = false;
                }
            }
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }
            else if (input == "")
            {
                if (scripture.IsCompletelyHidden())
                {
                    break;
                }
                scripture.HideRandomWords(3);
                Console.Clear();
            }
            else {
                error = true;
                Console.Clear();
            }
        }
    }

}
