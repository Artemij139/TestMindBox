using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMindBox.Figures.Interfaces;

namespace TestMindBox.Figures.Models
{
    public class Triangle :IFigure
    {
        
        public Triangle(double A, double B, double C)
        {
            if ( A < 0 ||  B < 0 || C < 0)
            {
                throw new ArgumentException("Стороны не могут быть меньше 0!");
            }

            _A = A;
            _B = B;
            _C = C;
        }
        public double _A { get; }
        public double _B { get; }
        public double _C { get; }

        public double calculateSquare()
        {
            var p = (_A + _B + _C) / 2;
            return Math.Round(Math.Sqrt(p * (p - _A) * (p - _B) * (p - _C)), Constans.RoundDigits);
        }

        public bool checkStraight()
        {   
            var sides = new List<double> { _A, _B, _C };

            var hypotenuse = sides.Max();

            var cathetuses = sides.Where(x => x != sides.Max()).ToList();

            return Math.Pow(hypotenuse, 2) == Math.Pow(cathetuses[0], 2) + Math.Pow(cathetuses[1], 2);
        }
    }
}
