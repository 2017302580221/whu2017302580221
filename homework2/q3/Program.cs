using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[99];
            for(int i=2;i<=100;i++)
            {
                a[i - 2] = i;
            }
            for(int i=2;i<=100;i++)
            {
               for(int j=2;j<=100;j++)
                {
                    if((a[i-2]%j==0)&&(a[i-2]!=j))
                    {
                        a[i - 2] = 0;
                    }
                }
            }
            for (int k = 2; k <= 100; k++)
            {
                if (a[k - 2] != 0)
                {
                    Console.Write(a[k - 2] + " ");
                }
            }
        }
    }
}
