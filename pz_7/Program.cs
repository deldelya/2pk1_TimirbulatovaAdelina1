using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rand = new Random();

            // Заполняем массив случайными числами
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 101);
            }

            Console.WriteLine("Все элементы массива:");


            // Выводим все элементы массива
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Уникальные элементы массива:");



            // Выводим только уникальные элементы массива
            for (int i = 0; i < array.Length; i++)
            {
                bool isUnique = true;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    Console.Write(array[i] + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
