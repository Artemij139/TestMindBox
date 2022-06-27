using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMindBox.Figures.Interfaces;

namespace TestMindBox.Figures.Models
{
    public class Figure : IFigure
    {
        public Figure(params double[] args) { 

           _args = args;
        }

        public double[] _args { get; }

        public double calculateSquare()
        {
            if (_args.Length == 1)
            {
                var circle = new Circle(_args[0]);

                return circle.calculateSquare();
            }

            if (_args.Length == 3)
            {   
                var triangle = new Triangle(_args[0], _args[1], _args[2]);
                return triangle.calculateSquare();
            }

            else
            {
                throw new ArgumentException("Возможно вычислить только площадь круга или треугольника, введите 1 или 3 параметра!");
            }
        }
    }
}
