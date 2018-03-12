using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveFilter
{
    public class ValueGroupFilter
    {
        public double Process2(double[] values)
        {
            List<double> result = values.ToList<double>();
            result.Sort();
            double mid = 0;
            if (result.Count % 2 == 0)
            {
                mid = (result[result.Count / 2] + result[result.Count / 2 - 1]) / 2;
            }
            else
            {
                mid = result[result.Count / 2];
            }

            return result[result.Count / 2];
        }



        public double Process(double[] values)
        {
            double average = values.Average();
            //分别判断
            List<double> bigger = new List<double>();
            List<double> smaller = new List<double>();
            for (int i = 0; i < values.Length; i++)
            {
                double temp = values[i];
                if (temp > average)
                {
                    bigger.Add(temp);
                }
                else
                {
                    smaller.Add(temp);
                }
            }

            //返回多数的平均值
            if (bigger.Count > smaller.Count)
            {
                return bigger.Average();
            }
            else
            {
                return smaller.Average();
            }

        }

    }
}
