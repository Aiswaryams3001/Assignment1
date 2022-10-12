using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class second
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter First Number:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number:");
            c=Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine(a + " is the largest Number");
            }
            else if(b>c && b>a)
            {
                Console.WriteLine(b + " is the largest Number");
            }
            else
            {
                Console.WriteLine(c + " is the largest Number");
            }
            Console.ReadLine();
        }
    }
}
