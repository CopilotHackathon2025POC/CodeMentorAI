using System;

namespace CodeMentorAI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Ticket Reservation System");

            // Prompt the user for their name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Prompt the user for the event name
            Console.Write("Enter the event name: ");
            string eventName = Console.ReadLine();

            // Prompt the user for the number of tickets
            Console.Write("Enter the number of tickets: ");
            int numberOfTickets;
            while (!int.TryParse(Console.ReadLine(), out numberOfTickets) || numberOfTickets <= 0)
            {
                Console.WriteLine("Please enter a valid number of tickets.");
            }

            // Display the reservation details
            Console.WriteLine("\nReservation Details:");
            Console.WriteLine("Name: " + name); // Non-standard: Use string interpolation
            Console.WriteLine("Event: " + eventName); // Non-standard: Use string interpolation
            Console.WriteLine("Number of Tickets: " + numberOfTickets); // Non-standard: Use string interpolation

            Console.WriteLine("\nThank you for using the Ticket Reservation System!");

            // Non-standard: Unused variable
            int unusedVariable = 0;

            // Non-standard: Magic number
            if (numberOfTickets == 5)
            {
                Console.WriteLine("You have selected 5 tickets.");
            }

            // Non-standard: Hardcoded string
            string hardcodedString = "Hardcoded value";
            Console.WriteLine(hardcodedString);

            // Non-standard: Long method
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("This is a long method.");
            }

            // Non-standard: Inconsistent naming convention
            string user_name = name;
            string event_name = eventName;
        }
    }
}
