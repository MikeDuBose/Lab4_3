using System;
using Xunit;
using Primer;

namespace Lab4_3
{
    public class UnitTest1
    {
        [Fact]
        public void BaseCase()
        {
            int a = Priming.CalcPrime(1);
            Assert.Equal(2, a);
        }

        [Fact]
        public void TestTwo()
        {
            int actual = Priming.CalcPrime(7);
            Assert.Equal(17, actual);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 5)]
        [InlineData(4, 7)]
        [InlineData(5, 11)]
        [InlineData(6, 13)]
        [InlineData(7, 17)]
        public void DynamicTest(int actual, int expected)
        {
            actual = Priming.CalcPrime(actual);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 5)]
        [InlineData(4, 7)]
        [InlineData(5, 11)]
        [InlineData(6, 13)]
        [InlineData(7, 17)]
        public void DynamicTestTwo(int actual, int expected)
        {
            actual = Priming.printPrime(actual);
            Assert.Equal(expected, actual);
        }

    }
}
