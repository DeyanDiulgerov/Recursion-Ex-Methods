using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partitions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\n\n\nWrite a function that counts the number of ways you can partition N objects using");
            Console.WriteLine($"parts up to M (asuuming M >= 0):");
            Console.WriteLine($"\nNumber of ways you can partition 7 objects using parts up to 4 is:");
            Console.WriteLine(Partitions(7, 4));
            Console.WriteLine("--------------------------------------------------------------------");

            Console.WriteLine($"\n\nNumber of ways you can partition 9 objects using parts up to 5 is:");
            Console.WriteLine(Partitions(9, 5));
            Console.WriteLine("--------------------------------------------------------------------\n");

            Console.WriteLine($"\nIf you want you can add N and M numbers For Testing");
            Console.Write("N == ");
            var n = int.Parse(Console.ReadLine());
            Console.Write("M == ");
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nNumber of ways you can partition {n} objects using parts up to {m} is:");
            Console.WriteLine(Partitions(n, m));
            Console.WriteLine("--------------------------------------------------------------------\n\n\n\n");
        }

        public static int Partitions(int n, int m)
        {
            if (n == 0)
                return 1;
            else if (m == 0 || n < 0)
                return 0;
            else
            {
                // Partitons(7, 4) == Partitions(3, 4) + Partitions(7, 3);
                return Partitions(n - m, m) + Partitions(n, m - 1);
            }
        }
    }
}
