using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int sum = 0;
            for(int i=1;i<=n;i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("The sum is :"+sum);
            Console.ReadLine();
        }
    }
}
