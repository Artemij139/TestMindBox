using System;
using TestMindBox.Figures.Models;
using Xunit;

namespace TestMindBox.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void Verify_calculate_triangle_square()
        {

            //arrange
            var triangle = new Triangle(14, 10.5, 17);
            var expectedSquare = 73.373;

            //act
            var triangleSquare = triangle.calculateSquare();

            //assert
            Assert.Equal(expectedSquare, triangleSquare);
        }

        [Fact]
        public void Shoud_throw_exception_when_argument_less_than_zero()
        {
            //assert
            Assert.Throws<ArgumentException>(() => new Triangle(-1, 15.5, 20.75));
        }

        [Fact]
        public void Shoud_be_straight()
        {
            //arrange
            var triangle = new Triangle(26, 10, 24);
            var expectedCheck = true;

            //act
            var actualCheck = triangle.checkStraight();

            //assert
            Assert.Equal(expectedCheck, actualCheck);
        }
    }
}
