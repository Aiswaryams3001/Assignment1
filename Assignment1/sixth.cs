﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class sixth
    {
        static void Main(string[] args)
        {
            int n,sum=0;
            Console.WriteLine("n:");
            n=Convert.ToInt32(Console.ReadLine());
            for(int i=0; i <= n; i++)
            {
                for(int j=1; j <=n-i; j++)
                {
                    Console.Write(" ");
                }
                for(int j=1; j <=2*i-1; j++)
                {
                    Console.Write("*");
                    sum = sum + 1;
                }
                Console.Write("\n");
            }
            Console.WriteLine("The sum of the pyramid is:" + sum.ToString());
            Console.ReadLine();
        }
    }
}
