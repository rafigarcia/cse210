using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Class Assigments");

        Assigment assigment = new Assigment("Marshal", "History");
        Console.WriteLine(assigment.GetSummary());

        MathAssigment mathAssigment = new MathAssigment("Perez", "Fractions", "1.9", "10-15");
        Console.WriteLine(mathAssigment.GetSummary());
        Console.WriteLine(mathAssigment.GetHomeworkList());

        WritingAssigment writingAssigment = new WritingAssigment("Smith", "History", "The Great War");
        Console.WriteLine(writingAssigment.GetSummary());
        Console.WriteLine(writingAssigment.GetWritingInformation());
        
    }
}