using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Third
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a Number:");
            n=Convert.ToInt32(Console.ReadLine());
            if(n>0)
            {
                Console.WriteLine("It is a Positive Number");
            }
            else
            {
                Console.WriteLine("It is a Negative Number");
            }
            Console.ReadLine();
        }
    }
}
