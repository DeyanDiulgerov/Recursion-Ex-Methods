using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prime Numbers are numbers which can ONLY be divided by 1 and itself
            // Composite Numbers are numbers which have more than two divisions

            Console.WriteLine(PrimeNumber(1));
            Console.WriteLine(PrimeNumber(2));
            Console.WriteLine(PrimeNumber(3));
            Console.WriteLine(PrimeNumber(4));
            Console.WriteLine(PrimeNumber(5));
            Console.WriteLine(PrimeNumber(6));
            Console.WriteLine(PrimeNumber(7));
            Console.WriteLine(PrimeNumber(11));
            Console.WriteLine(PrimeNumber(12));
            Console.WriteLine(PrimeNumber(13));
            Console.WriteLine(PrimeNumber(17));
            Console.WriteLine(PrimeNumber(19));
            Console.WriteLine(PrimeNumber(20));
            Console.WriteLine(PrimeNumber(23));
            Console.WriteLine(PrimeNumber(29));
            Console.WriteLine(PrimeNumber(31));
            Console.WriteLine(PrimeNumber(37));
            Console.WriteLine(PrimeNumber(41));
            Console.WriteLine(PrimeNumber(47));
            Console.WriteLine(PrimeNumber(51));
            Console.WriteLine(PrimeNumber(52));
            Console.WriteLine(PrimeNumber(53));
            Console.WriteLine(PrimeNumber(59));
            Console.WriteLine(PrimeNumber(61));
            Console.WriteLine(PrimeNumber(67));
            Console.WriteLine(PrimeNumber(71));
            Console.WriteLine(PrimeNumber(73));
            Console.WriteLine(PrimeNumber(79));
            Console.WriteLine(PrimeNumber(83));
            Console.WriteLine(PrimeNumber(84));
            Console.WriteLine(PrimeNumber(89));
            Console.WriteLine(PrimeNumber(97));
            Console.WriteLine(PrimeNumber(37));
            Console.WriteLine(PrimeNumber(8));

            Console.WriteLine($"\n--------------------------------------------");
            Console.WriteLine($"If you wish you can add a number For Testing");
            Console.Write($"Your Number == ");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(PrimeNumber(number));

        }

        public static string PrimeNumber(int number)
        {
            if (number == 1)
                return $"The number {number} is NOT a prime number";
            else if (number == 2)
                return $"The number {number} is a prime number";

            if (number % number == 0 && number / 1 == number && number % 2 == 0)
            {
                return $"The number {number} is NOT a prime number";
            }
            else
            {
                return $"The number {number} is a prime number";
            }
        }
    }
}
