using System;

class Program
{
    static void Main(string[] args)
    {
        Spinning spinning = new Spinning(55, new DateOnly(2024, 01, 01), 10);

        Running running = new Running(45, new DateOnly(2024, 02, 01), 33);

        Swimming swimming = new Swimming(40, new DateOnly(2024, 03, 01), 10);

        List<Activity> activities = new List<Activity> 
        {
            spinning, running, swimming
        };
        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
            Console.WriteLine();
        }
    }
}