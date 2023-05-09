using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_12
{
    internal class Program
    {
        static int Quarter(double x, double y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x < 0 && y > 0)
            {
                return 2;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else if (x > 0 && y < 0)
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            double x1 = 3.2, y1 = 2.7;
            double x2 = -5.1, y2 = 7.8;
            double x3 = -2.5, y3 = -4.9;

            int q1 = Quarter(x1, y1);
            int q2 = Quarter(x2, y2);
            int q3 = Quarter(x3, y3);

            Console.WriteLine("Точка 1 находится в {0} четверти", q1);
            Console.WriteLine("Точка 2 находится в {0} четверти", q2);
            Console.WriteLine("Точка 3 находится в {0} четверти", q3);

            Console.ReadLine();
        }
    }
}
