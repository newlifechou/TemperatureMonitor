using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemperatureMonitor
{
    /// <summary>
    /// 过滤器
    /// </summary>
    public class ValueFilter
    {
        public ValueFilter(double lv, double v)
        {
            LastValue = lv;
            Variable = v;
        }
        public double LastValue { get; set; }
        public double Variable { get; set; }
        public bool IsThisDataOK(double inputData)
        {
            bool result = inputData >= LastValue - Variable && inputData <= LastValue + Variable;
            if (result)
            {
                LastValue = inputData;
            }
            return result;
        }
    }
}
