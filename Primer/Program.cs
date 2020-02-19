using System;

namespace Primer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the sequence of the prime number you would like: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("The prime number at sequence " + a + " is " + Priming.printPrime(a));            
        }

        
    }
}
