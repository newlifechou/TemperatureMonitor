using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveFilter
{
    /// <summary>
    /// 最大最小值过滤
    /// </summary>
    public class MaxVariationFilter : IValueFilter
    {
        
        private double pDeviation, nDeviation;
        public MaxVariationFilter(double positive = 0, double negative = 0)
        {
            pDeviation = positive;
            nDeviation = negative;
        }

        /// <summary>
        /// 存储上一个符合要求的值
        /// </summary>
        public double CompareValue { get; set; }

        public double Filter(double input)
        {
            double dValue = input - CompareValue;
            bool predict = dValue <= pDeviation && dValue >= nDeviation;
            if (predict)
            {
                return input;
            }
            else
            {
                return -1;
            }
        }
    }
}
