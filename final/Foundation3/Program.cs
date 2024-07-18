using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("123 Main St", "Anytown", "CA", "12345");
        Event lecture = new Lecture("Tech Talk", "A lecture on the latest in tech", new DateTime(2024, 8, 12), "10:00 AM", lectureAddress, "Jane Doe", 100);

        Address receptionAddress = new Address("456 Elm St", "Othertown", "NY", "67890");
        Event reception = new Reception("Networking Event", "An event to network with industry professionals", new DateTime(2024, 9, 5), "6:00PM", receptionAddress, "rsvp@example.com");

        Address outdoorAddress = new Address("789 Oak St", "Sometown", "TX", "54321");
        Event outdoorGathering = new OutdoorGathering("Community Picnic", "A picnic for the community", new DateTime(2024, 7, 20), "1:00 PM", outdoorAddress, "Sunny and warm");

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