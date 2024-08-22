/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRabina
{
    internal class Lab111
    {
        static void Main()
        {
            Console.Write("Enter the number of rows for the first matrix: ");
            int rows1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns for the first matrix: ");
            int cols1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of rows for the second matrix: ");
            int rows2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns for the second matrix: ");
            int cols2 = Convert.ToInt32(Console.ReadLine());

            if (cols1 != rows2)
            {
                Console.WriteLine("Matrix multiplication is not possible with the given dimensions.");
                return;
            }

            int[,] matrix1 = new int[rows1, cols1];
            int[,] matrix2 = new int[rows2, cols2];
            int[,] result = new int[rows1, cols2];

            Console.WriteLine("\nEnter the elements of the first matrix:");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    Console.Write($"Element [{i + 1}, {j + 1}]: ");
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nEnter the elements of the second matrix:");
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write($"Element [{i + 1}, {j + 1}]: ");
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            Console.WriteLine("\nThe resulting matrix after multiplication is:");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write(result[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

*/