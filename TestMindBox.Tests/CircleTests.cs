using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMindBox.Figures.Models;
using Xunit;

namespace TestMindBox.Tests
{
    public class CircleTests
    {   
        [Fact]
        public void Verify_calculate_circle_square()
        {   
            
            //arrange
            var circle = new Circle(15.5);
            var expectedSquare = 754.385;

            //act
            var circleSquare = circle.calculateSquare();

            //assert
            Assert.Equal(expectedSquare, circleSquare);
        }

        [Fact]
        public void Shoud_throw_exception_when_radius_less_than_zero()
        {
            //assert
            Assert.Throws<ArgumentException>(()=>new Circle(-1));
        }

        
    }
}
