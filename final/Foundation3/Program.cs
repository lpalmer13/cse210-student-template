using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("123 Fart St", "Gasville", "FL", "12345");
        Event lecture = new Lecture("Silent but Deadly", "A lecture on the art of stealth farts", new DateTime(2024, 8, 12), "10:00 AM", lectureAddress, "Jane Doe", 100);

        Address receptionAddress = new Address("456 Toot Ln", "Flatulence City", "NY", "67890");
        Event reception = new Reception("Fart Festival", "A reception celebrating all things fart-related", new DateTime(2024, 9, 5), "6:00 PM", receptionAddress, "rsvp@fartfest.com");

        Address outdoorAddress = new Address("789 Gas Blvd", "Windy Town", "TX", "54321");
        Event outdoorGathering = new OutdoorGathering("Outdoor Fartathon", "A gathering for outdoor fart competitions", new DateTime(2024, 7, 20), "1:00 PM", outdoorAddress, "Sunny with a chance of wind");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (var e in events)
        {
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine();
            Console.WriteLine(new string('-', 50));

        }
    }
}