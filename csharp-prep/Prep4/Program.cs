using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        int input = -1;
        
        while (input != 0) 
        {
            Console.WriteLine("Enter a number: ");
            input = int.Parse(Console.ReadLine());
           
            if (input != 0)
            {
                numbers.Add(input);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the numbers is: {sum}");
        float average = ((float)sum) / numbers.Count;
        
        Console.WriteLine($"The average of the numbers is: {average}");
        
        int max = numbers [0];
        
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The maximum number is: {max}");


        int min = numbers [0];

        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
        }
        Console.WriteLine($"The minimum number is: {min}");

        numbers.Sort();

        Console.WriteLine($"The sorted numbers are:");
        foreach (int number in numbers)
        {
        Console.WriteLine($"{number} ");
        }

    }
}