using TestMindBox.Figures.Interfaces;

namespace TestMindBox.Figures.Models
{
    public class Circle : IFigure
    {
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть меньше 0!");
            }

            _radius = radius;

        }

        public double _radius { get; }

        public double calculateSquare()
        {
            return Math.Round((Constans.PiNumber * Math.Pow(_radius, 2)), Constans.RoundDigits);
        }
    }
}
