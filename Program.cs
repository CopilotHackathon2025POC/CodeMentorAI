using System;

namespace CodeMentorAI
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int x=10; // Issue: Missing space around the assignment operator
            int y = 20; // Issue: Unused variable
            string message = "Hello, World!"; // Issue: Variable name should be more descriptive
            Console.WriteLine(message);
            for(int i=0;i<10;i++) // Issue: Missing spaces around operators
            {
                Console.WriteLine("Iteration: " + i); // Issue: Use string interpolation instead of concatenation
            }
        }

}
