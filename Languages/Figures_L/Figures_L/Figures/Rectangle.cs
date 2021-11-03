using System;

namespace Figures_L.Figures_L
{
    public class Rectangle : IFigure
    {
        public int side1 { get; set; }
        public int side2 { get; set; }
        public Rectangle()
        {
            Random random = new Random();
            side1 = random.Next(1, 4);
            side2 = random.Next(1, 4);
        }
        public double Perimetr()
        {
            return (side1 + side2) * 2;
        }

        public double Square()
        {
            return side1 * side2;
        }

        public void GetInfo()
        {
            if (side1 == side2)
            {
                Console.WriteLine($"{"Квадрат",-19}{$"{side1}, {side2}",-11}{Perimetr(),-12}{Square(),-11}");
            }
            else
            {
                Console.WriteLine($"{"Прямоугольник",-19}{$"{side1}, {side2}",-11}{Perimetr(),-12}{Square(),-11}");
            }
        }
    }
}