using System;
using System.Xml.Serialization;
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();  
        Console.WriteLine("Welcome to the Journal Program!");
        
        while (true) 
        {
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("1) Write");
            Console.WriteLine("2) Display");
            Console.WriteLine("3) Load");
            Console.WriteLine("4) Save");
            Console.WriteLine("5) Quit");
            Console.Write("What would you like to do?");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.AddEntry();
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    journal.LoadFromFile();
                    break;

                case "4":
                    journal.SaveToFile();
                    break;

                case "5":
                    Environment.Exit(0);
                    break;
            }
        }  
    }    
}