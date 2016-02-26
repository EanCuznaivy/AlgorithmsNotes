using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicUtility
{
    public class EanUtility
    {
        /// <summary>
        /// 把正整数N表示为二进制并返回string类型
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static string IntToBinaryString(int N)
        {
            string str = "";
            for (int n = N; n > 0; n /= 2)
                str = (n % 2) + str;
            return str;
        }

        /// <summary>
        /// 生成一个整型的二维数组
        /// </summary>
        /// <returns>整型的二维数组</returns>
        public static Array CreateIntMatrix()
        {
            int M = EanRandom.Uniform(2, 10);
            int N = EanRandom.Uniform(2, 10);
            Array matrix = Array.CreateInstance(typeof(int), M, N);
            int a = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix.SetValue(a++, i, j);
                }
            }
            return matrix;
        }

        /// <summary>
        /// 打印二维数组
        /// </summary>
        /// <param name="arr"></param>
        public static void PrintMatrix(Array arr)
        {
            int M = arr.GetLength(0);
            int N = arr.GetLength(1);
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(arr.GetValue(i, j) + "\t");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 转置二维数组
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>转置后的二维数组</returns>
        public static Array Transposition(Array arr)
        {
            int M = arr.GetLength(0);
            int N = arr.GetLength(1);
            Array arr_t = Array.CreateInstance(arr.GetValue(0, 0).GetType(), N, M);
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    arr_t.SetValue(arr.GetValue(i, j), j, i);
                }
            }
            return arr_t;
        }

        /// <summary>
        /// 求log2N
        /// </summary>
        /// <param name="N"></param>
        /// <returns>返回不大于log2N的最大整数</returns>
        public static int Lg(int N)
        {
            int log2N = 0;
            while (N > 1)
            {
                N /= 2;
                log2N++;
            }
            return log2N;
        }

        /// <summary>
        /// 频数数组
        /// </summary>
        /// <param name="arr">整型数组</param>
        /// <param name="M">返回数组大小</param>
        /// <returns>返回第i个元素的值为整数i在参数数组中出现的次数的数组</returns>
        public static int[] Histogram(int[] arr, int M)
        {
            int[] arr_h = new int[M];
            foreach (var i in arr)
            {
                arr_h[i]++;
            }
            return arr_h;
        }

        /// <summary>
        /// 递归求斐波那契某位数
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static long FibRecursion(int N)
        {
            if (N == 0) return 0;
            if (N == 1) return 1;
            return FibRecursion(N - 1) + FibRecursion(N - 2);
        }

        /// <summary>
        /// 迭代求斐波那契某位数
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static long FibIteration(int N)
        {
            if (N == 0) return 0;
            if (N == 1) return 1;
            int fib = 1;
            int temp = 1;
            for (int i = 2; i < N; i++)
            {
                fib = checked(fib + temp);
                temp = fib - temp;
            }
            return fib;
        }

        /// <summary>
        /// 求斐波那契数列前N项
        /// </summary>
        /// <param name="fib"></param>
        /// <returns></returns>
        public static int[] Fib(int[] fib)
        {
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i < fib.Length; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            return fib;
        }


        /// <summary>
        /// 递归地求ln(N!)的值
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static double LnNFactorial(int N)
        {
            if (N > 1)
                return Math.Log(N, Math.E) + LnNFactorial(N - 1);
            else
                return 0;
        }

        /// <summary>
        /// 欧几里德算法计算p和q最大公约数
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public static int GCD(int p, int q)
        {
            if (q == 0) return p;
            int r = p % q;
            return GCD(q, r);
        }

        /// <summary>
        /// 扩展欧几里德算法，可以打印每次调用递归方法时的两个参数
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public static int Euclid(int p, int q)
        {
            if (q == 0) return p;
            int r = p % q;
            Console.WriteLine("parameter 1:{0}\tparameter 2:{1}", q, r);
            return Euclid(q, r);
        }

        /// <summary>
        /// 二项分布递归算法
        /// </summary>
        /// <param name="N"></param>
        /// <param name="k"></param>
        /// <param name="p"></param>
        /// <param name="depth">递归深度</param>
        /// <returns></returns>
        public static double Binomial(int N, int k, double p, int depth = 0)
        {
            if (N == 0 && k == 0)
                return 1.0;
            if (N < 0 || k < 0)
                return 0.0;
            //Console.WriteLine(depth);
            return (1.0 - p) * Binomial(N - 1, k, p) + p * Binomial(N - 1, k - 1, p);
        }

        /// <summary>
        /// 二项分布迭代算法
        /// </summary>
        /// <param name="N"></param>
        /// <param name="k"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static double[,] BinomialIteration(int N, int k, double p)
        {
            double[,] res = new double[N + 1, k + 1];
            res[0, 0] = 1;
            for (int i = 1; i < N + 1; i++)
                res[i, 0] = res[i - 1, 0] * (1 - p);
            for (int i = 0; i < N + 1; i++)
                for (int j = 1; j <= i && j < k + 1; j++)
                    res[i, j] = (1 - p) * res[i - 1, j] + p * res[i - 1, j - 1];
            return res;
        }
    }
}
