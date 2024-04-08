using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("202 Lake Blvd", "Minneapolis", "MN",  "USA");
        Address address2 = new Address("303 Hill St", "Seattle", "WA",  "USA");
        Address address3 = new Address("404 Valley View", "Cozumel", "AZ",  "MEXICO");

        Lecture lecture = new Lecture("Intro to C#", "Learn the basics of C#", "12/21/2024", "19:00", address1, "Kevin Mitnick", 1000);
        Reception reception = new Reception("C# Comunity Reception", "RSVP for C# Reception", "1/1/2025", "21:00", address2, "csharpinfo@gmail.com");
        Outdoor outdoor = new Outdoor("Skiing in the mountains", "Learn how to ski only for programmers", "8/1/2024", "17:00", address3, "Sunny");

        List<Event> events = new List<Event>()
        {
            lecture, reception,outdoor
        };

        Console.WriteLine("***********");
        foreach (Event e in events)
        {
            
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine();
            if (e != events[events.Count -1])
            {
                Console.WriteLine("***********");
            }
        }
        Console.WriteLine("That is all for now! You are up to date.");
    }
}