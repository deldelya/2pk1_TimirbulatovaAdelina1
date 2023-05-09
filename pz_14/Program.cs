using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_14
{
    internal class Program
    {
        public static void Main()
        {
            
            int nth_arithmetic = NthArithmeticTerm(4);
            Console.WriteLine("4 член арифметической прогрессии: " + nth_arithmetic);

            
            int nth_geometric = NthGeometricTerm(8);
            Console.WriteLine("8 член геометрической прогрессии: " + nth_geometric);
            Console.ReadLine();
        }

        public static int NthArithmeticTerm(int n)
        {
            if (n == 1)
            {
                return 50;
            }
            else
            {
                return NthArithmeticTerm(n - 1) + 3;
            }
        }

        public static int NthGeometricTerm(int n)
        {
            if (n == 1)
            {
                return 8;
            }
            else
            {
                return 4 * NthGeometricTerm(n - 1);
            }
        }
    }
}
