using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача__1
{
    class Program
    {
        static void Main(String[] args)
        {
            int i, m, j;
            Console.Write("Введите размер массива: ");
            m = int.Parse(Console.ReadLine());
            Double[] a = new double[m];
            Console.WriteLine("Введите массив:");
            for (i = 0; i < m; i++)
            {
                Console.Write("x[" + (i + 1) + "] = ");
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (i = 0; i < m; i++)
            {
                if (a[i]==0)
                {
                    for (j = i; j < (m - 1); j++)
                    {
                        a[j] = a[j + 1];
                    }
                    m--;
                    i--;
                }
            }
            Console.WriteLine("Массив после обработки:");
            for (i = 0; i < m; i++)
            {
                Console.WriteLine("x[" + (i+1) + "] = " + (a[i]));
            }
                Console.ReadLine();


        }
    }
}
