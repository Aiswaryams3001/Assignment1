using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class fifth
    {
        static void Main(string[] args)
        {
            int rollNo;
            double maths, chemistry, biology, total, percentage;
            string name;

            Console.WriteLine("Roll Number:");
            rollNo=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name:");
            name=Console.ReadLine();


            Console.WriteLine("Mark of Maths:");
            maths=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mark of chemistry:");
            chemistry=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mark of Biology:");
            biology=Convert.ToDouble(Console.ReadLine());

            total = maths + chemistry + biology;
            percentage = total / 3;
            Console.WriteLine("Total Marks ={0}\nPercentage ={1}",total,percentage);
            Console.ReadLine();
        }
    }
}
