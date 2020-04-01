using System;
using System.Collections.Generic;
namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Dans Grade Book");
            
            book.AddGrade(89.1);
            book.AddGrade(98.2);
            book.AddGrade(98.4);
            book.AddGrade(73.8);

            book.ShowStats();
        }
    }
}
