using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicUtility
{
    public class EanIn
    {
        /// <summary>
        /// 读取一个整数
        /// </summary>
        /// <returns></returns>
        public static int ReadInt()
        {
            return int.Parse(Console.ReadLine().ToString());
        }

        /// <summary>
        /// 读取一个实数
        /// </summary>
        /// <returns></returns>
        public static double ReadDouble()
        {
            return double.Parse(Console.ReadLine().ToString());
        }
    }
}
