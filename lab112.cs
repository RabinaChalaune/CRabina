/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRabina
{
    internal class Lab112
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of .NET technology subjects: ");
            int numSubjects = Convert.ToInt32(Console.ReadLine());

            int[] marks = new int[numSubjects];

            for (int i = 0; i < numSubjects; i++)
            {
                Console.Write($"Enter marks for subject {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            int minMark = marks[0];
            int maxMark = marks[0];
            int sum = 0;

            for (int i = 0; i < numSubjects; i++)
            {
                if (marks[i] < minMark)
                {
                    minMark = marks[i];
                }

                if (marks[i] > maxMark)
                {
                    maxMark = marks[i];
                }

                sum += marks[i];
            }

            double averageMark = (double)sum / numSubjects;

            Console.WriteLine($"\nMinimum Marks: {minMark}");
            Console.WriteLine($"Maximum Marks: {maxMark}");
            Console.WriteLine($"Average Marks: {averageMark:F2}");
        }
    }
}

*/