using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
                {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
                };

            int size = matrix.GetLength(0);
            int minBelowSecondaryDiagonal = Int32.MaxValue;

            Console.WriteLine("Исходная матрица:");


            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + "\t");// Выводим исходную матрицу
                }
                Console.WriteLine();
            }

            Console.WriteLine("Матрица ниже побочной диагонали:");


            // Выводим часть матрицы ниже побочной диагонали
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j > i)
                    {
                        Console.Write(matrix[i, j] + "\t");

                        if (matrix[i, j] < minBelowSecondaryDiagonal)
                        {
                            minBelowSecondaryDiagonal = matrix[i, j];
                        }
                    }
                    else
                    {
                        Console.Write("\t");
                        
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Минимальный элемент ниже побочной диагонали: " + minBelowSecondaryDiagonal);

            Console.ReadLine();
        }
    }
    
}
