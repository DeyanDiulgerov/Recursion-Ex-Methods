using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\nSum of all numbers before 5");
            Console.WriteLine(SumNumber(5));
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("\n\n\nSum of all numbers before 10");
            Console.WriteLine(SumNumber(10));
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("\n\n\nSum of all numbers before 100");
            Console.WriteLine(SumNumber(100));
            Console.WriteLine("----------------------------------------");

            Console.Write("\nIf you wish add another number For Testing:  ");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nSum of all numbers before {number}");
            Console.WriteLine($"{SumNumber(number)}");
            Console.WriteLine("----------------------------------------\n\n\n\n");
        }


        public static int SumNumber(int n)
        {
        // Sum(3) = 3 + Sum() == 3 + 2 + 1
        // Sum(6) = 6 + Sum(5)
        // Sum(5) = 5 + Sum(4)
        // ...................

            if (n <= 1)
                return 1;
            else
            {
                var result = n + SumNumber(n - 1);
                return result;
            }
        }

    }
}
