using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Найти наибольший элемент матрицы A(10,10) и записать ноль в те ячейки, где он находятся.
             * Вывести наибольший элемент, исходную и полученную матрицу.
             * Массив под измененную версию не нужен.
             */

            int[,] array =
            {
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                {15, 123, 43, 76, 34, 334, 768, 325, 222, 523},
                {54, 43, 23, 56, 78, 43, 234, 645, 346, 253},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                {15, 123, 43, 76, 34, 334, 768, 325, 222, 523},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                {54, 43, 23, 56, 78, 43, 234, 645, 346, 253},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                {54, 43, 23, 56, 78, 43, 234, 645, 346, 253},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
            };

            int MaxNumber = int.MinValue;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"[{array[i, j]}]");
                    if (array[i, j] > MaxNumber)
                    {
                        MaxNumber = array[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"MaxNumber - {MaxNumber}");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == MaxNumber)
                    {
                        array[i, j] = 0;
                    }
                    Console.Write($"[{array[i, j]}]");
                }

                Console.WriteLine();
            }


        }
    }
}
