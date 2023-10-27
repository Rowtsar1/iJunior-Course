using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_specific_rows
{
    internal class Program
    {
        /* Дан двумерный массив.
         * Вычислить сумму второй строки и произведение первого столбца.
         * Вывести исходную матрицу и результаты вычислений.
         */
        static void Main(string[] args)
        {
            int[,] array =
            {
                {1, 2, 3, 4, 5 },
                {7, 8, 9, 10, 11 },
                {12, 13, 14, 15, 16 }
            };

            int SumSecondString = 0;
            int SumFirstColumn = 1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == 1)
                    {
                        SumSecondString += array[i, j];
                    }

                    if (j < 1)
                    {
                        SumFirstColumn *= array[i, j];
                    }

                }
            }

            Console.WriteLine(SumSecondString);
            Console.WriteLine(SumFirstColumn);

        }
    }
}
