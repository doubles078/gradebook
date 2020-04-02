using System;
using System.Collections.Generic;

namespace Gradebook
{
    public class Book
    {   
        private List<double> _grades;
        private string _name;

        public Book(string name)
        {
            _grades = new List<double>();
            _name = name;
        }
       public void AddGrade(double grade) 
       {
           _grades.Add(grade);
       }

       public void ShowStats(){
            double sum = 0.0;
            double highGrade = double.MinValue;
            double minGrade = double.MaxValue;

            foreach (double number in _grades)
            {
                highGrade = Math.Max(number, highGrade);
                minGrade = Math.Min(number, minGrade);

                sum += number;
            }

            double average = sum / _grades.Count;

            System.Console.WriteLine($"The average grade is {average:N1}, the min grade is {minGrade:N1}, the highest grade is {highGrade:N1}.");
       }

       public Statistics GetStats(){

            var stats = new Statistics();

            double sum = 0.0;
            stats.Max = double.MinValue;
            stats.Min = double.MaxValue;

            foreach (double number in _grades)
            {
                stats.Max = Math.Max(number, stats.Max);
                stats.Min = Math.Min(number, stats.Min);

                sum += number;
            }

            stats.Average = sum / _grades.Count;
       
            return stats;
       }
    }
};
