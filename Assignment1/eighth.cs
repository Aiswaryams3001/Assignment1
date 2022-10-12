using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class eighth
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("n:");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=n;i>=1;i--)
            {
                for(int j=n;j>i;j--)
                {
                    Console.Write(" ");   
                }
                for (int k=1;k<(i*2);k++)
                {
                    Console.Write("*");  
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
