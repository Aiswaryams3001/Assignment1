using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class ten
    {
        static void Main(string[] args)
        {
            int n, product;
            Console.WriteLine("Enter a Number:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiplication Table");
            for (int i = 1; i <= 10; i++)
            {
                product = n * i;
                Console.WriteLine("{0}*{1}={2}", i, n, product);
            }
            Console.ReadLine();
        }
    }
}
