using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaveFilter;

namespace WaveFilterTest
{
    public class Program
    {
        public static void Main()
        {
            double[] values = { 0, 15, 14, 18, 12, 16, 13, 16, 88, 12 };
            //double[] values = { 21, 33, 24, 28, 22, 22, 23, 66, 88, 22 };
            ValueGroupFilter filter = new ValueGroupFilter();
            foreach (var item in values)
            {
                Console.Write($"{item} ");
            }
            double result=filter.Process2(values);

            Console.WriteLine($"Result={result}");

            //Random r = new Random();

            //for (int i = 0; i < 30; i++)
            //{
            //    double[] values = new double[10];
            //    for (int j = 0; j < values.Length; j++)
            //    {
            //        values[j] = r.Next(22, 99);
            //    }
            //    Console.Write($"第{i}组=");
            //    values.ToList().ForEach(k => Console.Write($"{k} "));
            //    double result = filter.Process2(values);
            //    Console.WriteLine($"第{i}组={result.ToString("F0")}");
            //}
            Console.Read();
        }
    }
}
