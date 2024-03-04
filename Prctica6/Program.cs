using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prctica6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write the value of x= ");
            double x = Convert.ToDouble(Console.ReadLine());
            double f = 5 * Math.Cos(2 * x);
            Console.WriteLine($"F is value = {f}");
            Console.WriteLine("Maskina");
            Console.ReadLine();

            

        }
    }
}
