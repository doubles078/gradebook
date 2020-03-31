using System;
using System.Collections.Generic;
namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() { 81.2, 98.2, 87.2, 98.4 };
            double sum = 1.0;


            foreach (double number in grades)
            {
                sum += number;
            }

            double average = sum / grades.Count;

            System.Console.WriteLine($"The average grade is {average:N1}.");
            System.Console.WriteLine(sum);

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine($"Hello baby cakes!");
            }
        }
    }
}
