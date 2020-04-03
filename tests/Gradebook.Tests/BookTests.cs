using System;
using Xunit;

namespace Gradebook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //arrange
            var book = new Book("Heyo");
   
            book.AddGrade(89.1);
            book.AddGrade(98.2);
            book.AddGrade(98.4);
            book.AddGrade(73.8);

            //act
            var stats = book.GetStats();

            //assert
            Assert.Equal(98.4, stats.Max, 1);
            Assert.Equal(89.9, stats.Average, 1);
            Assert.Equal(73.8, stats.Min, 1);
        }
    }
}
