using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 11, 3, 47, 2, 43 };
            int max = 0, min = 0, sum = 0;
            double aver = 0;
            //求最大值
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] < a[i + 1])
                {
                    max = a[i + 1];
                }
                else
                {
                    max = a[i];
                }
            }
            Console.WriteLine("最大值:" + max);
            //求最小值
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] < a[i + 1])
                {
                    min = a[i];
                }
                else
                {
                    min = a[i + 1];
                }
            }
            Console.WriteLine("最小值:" + min);
            //求和
            for(int i=0;i<a.Length;i++)
            {
                sum += a[i];
            }
            Console.WriteLine("和:" + sum);
            //平均值
            aver =(double) sum / a.Length;
            Console.WriteLine("平均值:" + aver);
        }
    }
}
