using System;

namespace Figures_L.Figures
{
    public class Triangle : Calculation, IFigure
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public double side3 { get; set; }
        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        //Проверка на вид треугольника
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
        public override double Perimetr()
        {
            return side1 + side2 + side3;
        }
        public override double Square()
        {
            double Semiperimeter;
            Semiperimeter = (side1 + side2 + side3) / 2;
            return (Math.Sqrt(Semiperimeter * (Semiperimeter - side1) * (Semiperimeter - side2) * (Semiperimeter - side3)));
        }
        public void GetInfo()
        {
            Console.WriteLine("Информация о треугольнике:");
            Console.WriteLine($"Вид треугольника:{Verification()}");
            Console.WriteLine($"Периметр треугольника:{Perimetr()}");
            Console.WriteLine($"Площадь треугольника:{Square()}");
        }

    }
}
