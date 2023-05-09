using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] str = "hello".ToCharArray();
            int length = str.Length;
            unsafe { 
                fixed (char* start = str)
                {
                char* end = start + length - 1;
                    while (start < end)
                    {
                        char temp = *start;
                        *start = *end;
                        *end = temp;
                        end--;
                    }
                }
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
