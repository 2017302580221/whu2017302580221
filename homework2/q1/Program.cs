using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string s = Console.ReadLine();
            a = Int32.Parse(s);
            int b = a;
            for(int i=2;i<=b;)
            {
                if( b % i == 0)
                {
                    b = b / i;
                    Console.Write(i + " ");
                    i = 2;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
