using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumFromNTo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\n\nWrite a program in C# Sharp to print numbers from n to 1 using recursion.");
            Console.WriteLine($"-------------------------------------------------------------------------------\n");

            Console.WriteLine($"Numbers from 5 to 1:");
            Console.WriteLine(PrintNatural(5, 5));
            Console.WriteLine($"-------------------------------------------------------------------------------\n");

            Console.WriteLine($"Numbers from 10 to 1:");
            Console.WriteLine(PrintNatural(10, 10));
            Console.WriteLine($"-------------------------------------------------------------------------------\n");

            Console.WriteLine($"Numbers from 20 to 1:");
            Console.WriteLine(PrintNatural(20, 20));
            Console.WriteLine($"-------------------------------------------------------------------------------\n");

            Console.WriteLine($"If you wish you can add another number For Testing");
            Console.Write($"Your number == ");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintNatural(number, number));
            Console.WriteLine($"-------------------------------------------------------------------------------\n\n");

        }

        public static int PrintNatural(int number, int counter)
        {
            if (counter <= 1)
                return number;
            else
            {
                counter--;
                Console.Write(number + " ");
                return PrintNatural(number - 1, counter);
            }
        }
    }
}
