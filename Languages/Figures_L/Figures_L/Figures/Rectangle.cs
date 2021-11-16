using System;

namespace Figures_L.Figures_L
{
    public class Rectangle : IFigure
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public Rectangle()
        {
            Random random = new Random();
            side1 = random.Next(1, 4);
            side2 = random.Next(1, 4);
        }
        public double Perimetr()
        {
            return Math.Round(((side1 + side2) * 2),4);
        }

        public double Square()
        {
            return Math.Round((side1 * side2),4);
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