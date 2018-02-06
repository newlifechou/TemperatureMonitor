using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveFilter
{
    /// <summary>
    ///过滤器接口
    /// </summary>
    public interface IValueFilter
    {
        /// <summary>
        /// 过滤器接口
        /// </summary>
        /// <param name="input">输入值</param>
        /// <returns>返回小于0表示改值不符合要求，返回其他值OK</returns>
        double Filter(double input);
    }
}
