using System;

namespace BasicUtility
{
    public class EanRandom
    {
        private static Random random = new Random();

        /// <summary>
        /// 设置随机生成器的种子
        /// </summary>
        /// <param name="seed">随机数种子</param>
        public static void SetSeed(int seed)
        {
            random = new Random(seed);
        }

        /// <summary>
        /// [0.0, 1.0)之间的实数
        /// </summary>
        /// <returns>随机返回[0.0, 1.0)之间的实数</returns>
        public static double Random()
        {
            return random.NextDouble();
        }

        /// <summary>
        /// [0, N-1]之间的整数
        /// </summary>
        /// <param name="maxValue"></param>
        /// <returns>随机返回[0, N-1]之间的整数</returns>
        public static int Uniform(int N)
        {
            return random.Next(N);
        }

        /// <summary>
        /// [lo, hi-1]之间的整数
        /// </summary>
        /// <param name="lo"></param>
        /// <param name="hi"></param>
        /// <returns>随机返回[lo, hi-1]之间的整数</returns>
        public static int Uniform(int lo, int hi)
        {
            return random.Next(lo, hi);
        }

        /// <summary>
        /// [lo, hi)之间的实数
        /// </summary>
        /// <param name="lo"></param>
        /// <param name="hi"></param>
        /// <returns>随机返回[lo, hi)之间的实数</returns>
        public static double Uniform(double lo, double hi)
        {
            return lo + EanRandom.Random() * (hi - lo);
        }

        /// <summary>
        /// 有p的概率返回true
        /// </summary>
        /// <param name="p">返回true的概率为p</param>
        /// <returns></returns>
        public static bool Bernoulli(double p)
        {
            return EanRandom.Random() <= p ? true : false;
        }

        /// <summary>
        /// 服从正态分布的实数
        /// </summary>
        /// <param name="m">期望值，默认为0</param>
        /// <param name="s">标准差，默认为1</param>
        /// <returns>随机返回服从正态分布的实数</returns>
        public static double Gaussian(double m = 0, double s = 1)
        {
            return 1;
        }

        /// <summary>
        /// 返回i的概率为a[i]
        /// </summary>
        /// <param name="a"></param>
        /// <returns>根据离散概率随即返回的int值（出现i的概率为a[i]）</returns>
        public static int Discrete(double[] a)
        {
            double r = EanRandom.Random();
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
                if (sum >= r)
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// 将double类型数组中的元素随机排序
        /// </summary>
        /// <param name="a"></param>
        public static void Shuffle(double[] a)
        {
            int length = a.Length;
            for (int i = 0; i < length; i++)
            {
                int r = i + EanRandom.Uniform(length - i);
                double temp = a[i];
                a[i] = a[r];
                a[r] = temp;
            }
        }
    }
}
