using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class first
    {
        static void Main(string[] args)
        {
            int n, r, temp, sum = 0;
            Console.WriteLine("Enter a Number:");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while (temp > 0)
            {
                r = n % 10;
                sum = sum + r;
                temp = temp / 10;

            }
            Console.WriteLine("The sum of digits is: " + sum);
            Console.ReadLine();
        }
    }
}
