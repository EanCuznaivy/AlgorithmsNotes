using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace BasicUtility
{
    public class EanDraw
    {
        static Window window = new Window() { Title = "EanDraw", Height = 500, Width = 500, Background = Brushes.LightBlue };
        static Canvas canvas = new Canvas();

        /// <summary>
        /// 显示图像
        /// </summary>
        /// <param name="seconds"></param>
        public static void Show()
        {
            window.Content = canvas;
            window.Show();
        }

        /// <summary>
        /// 画线
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        public static void Line(double x1, double y1, double x2, double y2)
        {
            canvas.Children.Add(new Line() { X1 = x1, X2 = x2, Y1 = y1, Y2 = y2,  Stroke = Brushes.Black});
        }
    }
}
