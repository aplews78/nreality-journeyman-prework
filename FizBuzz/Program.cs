using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizBuzz
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("--Press any key to start fizz buzz!");
            Console.ReadKey();

            var c = 0;
            for (c = 1; c <= 100; c += 1)
            {
                if (c % 3 == 0 && c % 5 != 0)
                    Console.WriteLine("Fizz");
                else if (c % 5 == 0 && c % 3 != 0)           
                    Console.WriteLine("Buzz");                
                else if (c % 3 == 0 && c % 5 == 0)                
                    Console.WriteLine("FizzBuzz");                
                else                
                    Console.WriteLine(c);                
            }

            Console.WriteLine("--Fizz buzz complete!");
            Console.ReadKey();
        }
    }
}
