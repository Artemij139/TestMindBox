using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMindBox.Figures.Models;
using Xunit;

namespace TestMindBox.Tests
{
    public class FigureTests
    {
        [Fact]
        public void Calculate_square_when_figure_is_triangle()
        {

            //arrange
            var figure = new Figure(20.296, 17, 5.89);
            var expectedSquare = 44.943;

            //act
            var actualSquare = figure.calculateSquare();

            //assert
            Assert.Equal(expectedSquare, actualSquare);
        }

        [Fact]
        public void Calculate_square_when_figure_is_circle()
        {
            //arrange
            var figure = new Figure(35);
            var expectedSquare = 3846.5;

            //act
            var actualSquare = figure.calculateSquare();

            //assert
            Assert.Equal(expectedSquare, actualSquare);

        }

        [Fact]
        public void Shoud_throw_exception_when_arguments_not_1_or_3()
        {
            //assert
            Assert.Throws<ArgumentException>(() => new Figure(35, 14, 6, 8).calculateSquare());
        }

        


    }
}
