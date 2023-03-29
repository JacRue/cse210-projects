using System;

namespace InheritanceWithEventPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("123 Main St", "AnyTown", "CA", 12345);
            Address address2 = new Address("456 Oak Ave", "Othertown", "NY", 67890);
            Address address3 = new Address("789 Elm Blvd", "Another Town", "TX", 54321);

            Lecture lecture = new Lecture("The Future of AI", " A talk about the lastest developments in artificial intelligence", new DateTime(2023, 04, 15), new TimeSpan(18, 0, 0), address1, "Dr. Jane Smith", 50);

            Reception reception = new Reception("Company Reception", "Join us for an evening of food and drinks", new DateTime(2023, 05, 20), new TimeSpan(19, 0, 0), address2, "rsvp@company.com");

            OutdoorGathering gathering = new OutdoorGathering("Summer Festival", "A celebration of summer with live music and food trucks", new DateTime(2023, 06, 30), new TimeSpan(16, 0, 0), address3, "Sunny and warm");

            Console.WriteLine("Standard details:\n");
            Console.WriteLine(lecture.GetStandardDetails() + "\n");
            Console.WriteLine(reception.GetStandardDetails() + "\n");
            Console.WriteLine(gathering.GetStandardDetails() + "\n");

            Console.WriteLine("Full details:\n");
            Console.WriteLine(lecture.GetFullDetails() + "\n");
            Console.WriteLine(reception.GetFullDetails() + "\n");
            Console.WriteLine(gathering.GetFullDetails() + "\n");

            Console.WriteLine("Short description:\n");
            Console.WriteLine(lecture.GetShortDescription() + "\n");
            Console.WriteLine(reception.GetShortDescription() + "\n");
            Console.WriteLine(gathering.GetShortDescription() + "\n");

            Console.ReadLine();
        }
    }
}