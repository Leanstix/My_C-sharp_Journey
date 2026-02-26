using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_C_sharp_journey
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print Hellow world using the hello.cs class
            Console.WriteLine(HelloMessage.Get());
            int age= 25;
            Console.WriteLine($"I am {age} years old");

            long population = 7800000000L;
            Console.WriteLine($"The world population is approximately {population}");
            Console.ReadLine();
        }
    }
}
