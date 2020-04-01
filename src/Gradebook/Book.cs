using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Book
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
    }
};
