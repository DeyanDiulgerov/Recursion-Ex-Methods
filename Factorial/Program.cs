using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\nFactorial of all numbers before 3");
            Console.WriteLine(Factorial(3));
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("\n\n\nnFactorial of all numbers before 6");
            Console.WriteLine(Factorial(6));
            Console.WriteLine("----------------------------------------");

            Console.Write("\nIf you wish add another number For Testing:  ");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nFactorial of all numbers before {number}");
            Console.WriteLine($"{Factorial(number)}");
            Console.WriteLine("----------------------------------------\n\n\n\n");
        }

        public static int Factorial(int n)
        {
            // 3! = 3*2*1 == 6
            // 6! = 6*5*4*3*2*1 == 720
            // 6! = 6 * 5!......

            if (n == 1)
                return 1;
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
