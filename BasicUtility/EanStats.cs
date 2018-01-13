using System;
using System.Linq;

namespace BasicUtility
{
    public class EanStats
    {
        /// <summary>
        /// 数组最大值
        /// </summary>
        /// <param name="a"></param>
        /// <returns>最大值</returns>
        public static double Max(double[] a)
        {
            return a.Max();
        }

        /// <summary>
        /// 数组最小值
        /// </summary>
        /// <param name="a"></param>
        /// <returns>最小值</returns>
        public static double Min(double[] a)
        {
            return a.Min();
        }

        /// <summary>
        /// 数组平均值
        /// </summary>
        /// <param name="a"></param>
        /// <returns>平均值</returns>
        public static double Mean(double[] a)
        {
            return a.Average();
        }

        /// <summary>
        /// 数组采样方差
        /// </summary>
        /// <param name="a"></param>
        /// <returns>采样方差</returns>
        public static double Var(double[] a)
        {
            double var = 0;
            foreach (var x in a)
            {
                var += Math.Pow((x - a.Average()), 2);
            }
            return var / a.Length;
        }

        /// <summary>
        /// 数组采样标准差
        /// </summary>
        /// <param name="a"></param>
        /// <returns>采样标准差</returns>
        public static double Stddev(double[] a)
        {
            return Math.Sqrt(EanStats.Var(a));
        }

        /// <summary>
        /// 数组中位数
        /// </summary>
        /// <param name="a"></param>
        /// <returns>中位数</returns>
        public static double Median(double[] a)
        {
            Array.Sort(a);
            return a[(int)(a.Length / 2)];
        }
    }
}
