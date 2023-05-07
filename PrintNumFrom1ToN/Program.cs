using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumFrom1ToN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\n\nWrite a program in C# Sharp to print numbers from 1 to N using recursion.");
            Console.WriteLine($"-------------------------------------------------------------------------------\n");

            Console.WriteLine($"Numbers from 1 to 5:");
            Console.WriteLine(PrintNatural(5, 1));
            Console.WriteLine($"-------------------------------------------------------------------------------\n");

            Console.WriteLine($"Numbers from 1 to 10:");
            Console.WriteLine(PrintNatural(10, 1));
            Console.WriteLine($"-------------------------------------------------------------------------------\n");

            Console.WriteLine($"Numbers from 1 to 20:");
            Console.WriteLine(PrintNatural(20, 1));
            Console.WriteLine($"-------------------------------------------------------------------------------\n");

            Console.WriteLine($"If you wish you can add another number For Testing");
            Console.Write($"Your number == ");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintNatural(number, 1));
            Console.WriteLine($"-------------------------------------------------------------------------------\n\n");

        }

        public static int PrintNatural(int number, int counter)
        {
            if (number == 1)
                return counter;
            else
            {
                Console.Write(counter + " ");
                counter++;
                return PrintNatural(number - 1, counter);
            }
        }
    }
}
