using System;

namespace CodeMentorAI
{
    class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Ticket Reservation System");

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the event name: ");
        string eventName = Console.ReadLine();

        int numberOfTickets = 0;
        bool validInput = false;

        while (!validInput)
        {
            Console.Write("Enter the number of tickets: ");
            if (int.TryParse(Console.ReadLine(), out numberOfTickets) && numberOfTickets > 0)
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Please enter a valid number of tickets..");
            }
        }

        Console.WriteLine($"Reservation confirmed for {name} to the event {eventName} with {numberOfTickets} tickets.");
    }
}
}
