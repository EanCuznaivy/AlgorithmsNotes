using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicUtility
{
    public class BinarySearch
    {
        /// <summary>
        /// 二分查找
        /// </summary>
        /// <param name="key">要查找的值</param>
        /// <param name="a">有序数组</param>
        /// <returns>不存在返回-1</returns>
        public static int Rank(int key, int[] a)
        {
            int lo = 0;
            int hi = a.Length - 1;
            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (key < a[mid])
                    hi = mid - 1;
                else if (key > a[mid])
                    lo = mid + 1;
                else
                    return mid;
            }
            return -1;
        }

        /// <summary>
        /// 递归二分查找
        /// </summary>
        /// <param name="key"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int RankRecursion(int key, int[] a)
        {
            return RankRecursion(key, a, 0, a.Length - 1);
        }

        /// <summary>
        /// 递归二分查找
        /// </summary>
        /// <param name="key"></param>
        /// <param name="a"></param>
        /// <param name="lo"></param>
        /// <param name="hi"></param>
        /// <returns></returns>
        public static int RankRecursion(int key, int[] a, int lo, int hi)
        {
            if (lo > hi) return -1;
            int mid = lo + (hi - lo) / 2;
            if (key < a[mid]) return RankRecursion(key, a, lo, mid - 1);
            else if (key > a[mid]) return RankRecursion(key, a, mid + 1, hi);
            else return mid;
        }


        /// <summary>
        /// 带递归深度的递归二分查找
        /// </summary>
        /// <param name="key"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int RankRecursionWithDepth(int key, int[] a)
        {
            return RankRecursionWithDepth(key, a, 0, a.Length - 1);
        }

        /// <summary>
        /// 带递归深度的递归二分查找
        /// </summary>
        /// <param name="key"></param>
        /// <param name="a"></param>
        /// <param name="lo"></param>
        /// <param name="hi"></param>
        /// <param name="depth">递归深度</param>
        /// <returns></returns>
        public static int RankRecursionWithDepth(int key, int[] a, int lo, int hi, int depth = 0)
        {
            if (lo > hi) return -1;
            int mid = lo + (hi - lo) / 2;
            depth++;
            if (key < a[mid])
            {
                
                for (int i = 1; i < depth; i++) Console.Write("\t");
                Console.WriteLine("lo:{0}\thi:{1}", lo, mid - 1);
                return RankRecursionWithDepth(key, a, lo, mid - 1, depth);
            }
            else if (key > a[mid])
            {
                for (int i = 1; i < depth; i++) Console.Write("\t");
                Console.WriteLine("lo:{0}\thi:{1}", mid + 1, hi);
                return RankRecursionWithDepth(key, a, mid + 1, hi, depth);
            }
            else return mid;
        }

        /// <summary>
        /// 二分法测试用例之白名单过滤
        /// </summary>
        /// <param name="whitelist"></param>
        /// <param name="flag">+：打印出不在白名单的值；-：打印出在白名单的值</param>
        public static void BinarySearchTestCase(int[] whitelist, char flag = '+')
        {
            //假设白名单已经排好序
            int input = 0;
            while(input >= 0)
            {
                Console.WriteLine("Input an integer（-1 to exit）：");
                input = EanIn.ReadInt();
                if (Rank(input, whitelist) < 0 && flag =='+')
                    Console.WriteLine("{0} not exists in whilelist", input);
                if (Rank(input, whitelist) >= 0 && flag == '-')
                    Console.WriteLine("{0} exists in whilelist", input);
            }
        }

        /// <summary>
        /// 返回数组中小于键值的元素数量
        /// </summary>
        /// <param name="key"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int LessThanKeyCount(int key, int[] a)
        {
            int lo = 0;
            int hi = a.Length - 1;
            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (key < a[mid])
                    hi = mid - 1;
                else if (key > a[mid])
                    lo = mid + 1;
                else
                {
                    while (a[mid] == a[mid - 1] && mid > 0)
                        mid--;
                    return mid;
                }
            }
            return -1;
        }

        /// <summary>
        /// 返回数组中等于键值的元素数量
        /// </summary>
        /// <param name="key"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int EqualToKeyCount(int key, int[] a)
        {
            int lo = 0;
            int hi = a.Length - 1;
            int count = 1;
            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (key < a[mid])
                    hi = mid - 1;
                else if (key > a[mid])
                    lo = mid + 1;
                else
                {
                    int temp = mid;
                    while (a[temp] == a[temp - 1] && temp > 0)
                    {
                        temp--;
                        count++;
                    }
                    temp = mid;
                    while (a[temp] == a[temp + 1] && temp < a.Length)
                    {
                        temp++;
                        count++;
                    }
                    return count;
                }
            }
            return -1;
        }
    }
}
