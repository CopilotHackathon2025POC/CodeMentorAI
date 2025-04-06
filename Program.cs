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
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Event: {eventName}");
            Console.WriteLine($"Number of Tickets: {numberOfTickets}");

            Console.WriteLine("\nThank you for using the Ticket Reservation System!");
        }
    }
}
