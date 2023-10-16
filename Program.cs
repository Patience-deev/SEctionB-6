using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEctionB_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(11, 20, 12));
            Console.WriteLine(test(30, 30, 17));
            Console.WriteLine(test(25, 35, 50));
            Console.WriteLine(test(15, 12, 8));
            Console.ReadLine();
        }
        public static bool test(int a, int b, int c)
        {
            return (a >= 20 && a <= 50) || (b >= 20 && b <= 50) || (c >= 20 && c <= 50);
        }
    }
}
