using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveFilter
{
    public class ValueFilterBase
    {
        private List<double> initialValues;
        public ValueFilterBase()
        {
            initialValues = new List<double>();
        }

        /// <summary>
        /// 读入足够多的样品数据
        /// </summary>
        /// <param name="n"></param>
        public void ReadInSampleValue(double n)
        {
            initialValues.Add(n);
        }

        /// <summary>
        /// 从样品数据中判断开始值
        /// </summary>
        /// <returns></returns>
        public double GetProperStartValue()
        {
            double result = 0;
            double average = 0;

            return result;
        }
    }
}
