using System;

namespace Figures_L.Figures_L
{
    public class Triangle : IFigure
    {
        public int side1 { get; set; }
        public int side2 { get; set; }
        public int side3 { get; set; }
        public Triangle()
        {
            Random random = new Random();
            while(!(side1+side2>side3&& side1 + side3 > side2 && side3 + side2 > side1))
            {
                side1 = random.Next(1, 4);
                side2 = random.Next(1, 4);
                side3 = random.Next(1, 4);
            }
        }
        //Метод, который проверяет, существует ли треугольник
        public double Perimetr()
        {
            return (double)(side1 + side2 + side3);
        }
        public double Square()
        {
            double Semiperimeter;
            double Area;
            Semiperimeter = (side1 + side2 + side3) / 2;
            Area = Math.Round(Math.Sqrt(Semiperimeter * (Semiperimeter - side1) * (Semiperimeter - side2) * (Semiperimeter - side3)));
            return Area;
        }
        public string Verification()
        {
            if (side1 == side2 && side1 == side3)
            {
                return "Равносторонний";
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                return "Равнобедренный";
            }
            else
            {
                return "Разносторонний";
            }
        }
        public void GetInfo()
        {
            Console.WriteLine($"{"Треугольник",-19}{$"{side1}, {side2}, {side3}",-11}{Perimetr(),-12}{Square(),-11}{Verification(),-20}");
        }
    }
}
