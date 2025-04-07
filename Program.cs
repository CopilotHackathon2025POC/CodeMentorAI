using System;

namespace CodeMentorAI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a nummber:");
            int n = Convert.ToInt32(Console.ReadLine());
 
            if (GetPrime(n))
            {
                Console.WriteLine($"{n} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{n} is a prime number.");
            }
        }
 
        static bool GetPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i < num; i++)
            {
                if (num % i > 0) return false;
            }
            return true;
        }
    }
}
