using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class fourth
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter First Number:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number:");
            b=Convert.ToInt32(Console.ReadLine());
            if(a==b)
            {
                Console.WriteLine("{0} and {1} are equal",a,b);
            }
            else
            {
                Console.WriteLine("{0} and {1} are not equal", a, b);
            }
            Console.ReadLine();
        }
    }
}
