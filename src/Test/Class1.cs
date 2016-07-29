using System;
using Web;
using Xunit;

namespace Test
{
    public class Class1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, SimpleCalculator.Add(2, 2));
        }



        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        //[InlineData(6)]
        public void MyFirstTheory(int value)
        {
            Assert.True(SimpleCalculator.IsOdd(value));
        }


    }
}
