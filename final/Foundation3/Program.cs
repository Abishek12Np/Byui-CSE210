using System;
// Main program class
class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "City", "State", "12345");
        Address address2 = new Address("456 Elm St", "City", "State", "67890");
        Address address3 = new Address("789 Oak St", "City", "State", "54321");

        // Create instances of each event type
        Lecture lecture = new Lecture("Python Programming Lecture", "Learn Python programming basics", "2024-04-15", "10:00 AM", address1, "John Doe", 50);
        Reception reception = new Reception("Networking Reception", "Network with professionals", "2024-04-20", "6:00 PM", address2, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Picnic in the Park", "Enjoy outdoor activities", "2024-05-01", "12:00 PM", address3, "Sunny");

        // Create an array to store event instances
        Event[] events = { lecture, reception, outdoorGathering };

        // Iterate over each event and generate marketing messages
        foreach (Event e in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(e.StandardDetails());
            Console.WriteLine("\nFull Details:");
            Console.WriteLine(e.FullDetails());
            Console.WriteLine("\nShort Description:");
            Console.WriteLine(e.ShortDescription());
            Console.WriteLine("\n");
        }
    }
}
