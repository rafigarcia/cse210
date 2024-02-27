using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade?");
        string number = Console.ReadLine();
        int grade = int.Parse(number);
        
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

        int lastDigit = grade % 10;
        string modifier = "";
        
        if (grade >= 90)
        {
            modifier ="";
        }
    
        else if (grade >= 60)
        {
            if (lastDigit >= 7)
            {
                modifier = "+";
            }
            else if (lastDigit <= 3 && lastDigit != 0)
            {
                modifier = "-";
            }   
        }
        
        Console.WriteLine($"Your grade is {grade}, and your letter grade is {modifier}{letter}.");

        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }

        else {
            Console.WriteLine("You failed.");
        }
    }
}