using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            double m = 0;
            double n = 0;
            Console.WriteLine("Please input a number:");
            s = Console.ReadLine();
            m = double.Parse(s);
            Console.WriteLine("Please input a number:");
            s = Console.ReadLine();
            n = Double.Parse(s);
            double p = m * n;
            Console.WriteLine(m + "*" + n + "=" + p);
        }
    }
}
