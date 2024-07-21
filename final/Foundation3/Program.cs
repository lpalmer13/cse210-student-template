using System;

public class Program
{
    static void Main(string[] args)
    {
        Address fartLectureAddress = new Address("123 Fart St", "Gasville", "FL", "12345");
        Event fartLecture = new Lecture("Silent but Deadly", "A lecture on the art of stealth farts", new DateTime(2024, 8, 12), "10:00 AM", fartLectureAddress, "Jane Doe", 100);

        Address dumpLectureAddress = new Address("123 Dump Rd", "Messyville", "CA", "34567");
        Event dumpLecture = new Lecture("The Ultimate Dump", "A comprehensive lecture on the art and science of taking the perfect dump", new DateTime(2024, 8, 20), "10:00 AM", dumpLectureAddress, "Dr. Stinker", 100);

        Address fartReceptionAddress = new Address("456 Toot Ln", "Flatulence City", "NY", "67890");
        Event fartReception = new Reception("Fart Festival", "A reception celebrating all things fart-related", new DateTime(2024, 9, 5), "6:00 PM", fartReceptionAddress, "rsvp@fartfest.com");

        Address dumpReceptionAddress = new Address("456 Stinky Ave", "Toilet Town", "NY", "45678");
        Event dumpReception = new Reception("Dump Fest", "A reception celebrating everything related to taking a dump", new DateTime(2024, 9, 18), "6:00 PM", dumpReceptionAddress, "rsvp@dumpfest.com");

        Address fartOutdoorAddress = new Address("789 Gas Blvd", "Windy Town", "TX", "54321");
        Event fartOutdoorGathering = new OutdoorGathering("Outdoor Fartathon", "A gathering for outdoor fart competitions", new DateTime(2024, 7, 20), "1:00 PM", fartOutdoorAddress, "Sunny with a chance of wind");

        Address dumpOutdoorAddress = new Address("789 Crap Blvd", "Filthy City", "TX", "76543");
        Event dumpOutdoorGathering = new OutdoorGathering("Dump Day Picnic", "An outdoor event where participants share their best dump stories", new DateTime(2024, 7, 31), "1:00 PM", dumpOutdoorAddress, "Sunny with occasional odor");

        Event[] events = { fartLecture, dumpLecture, fartReception, dumpReception, fartOutdoorGathering, dumpOutdoorGathering };

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