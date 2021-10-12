using System;

namespace Figures_L.Figures
{
    public class Rectangle : IFigure
    {
        private double side1;
        private double side2;
        public double Side1
        {
            get { return side1; }
            set
            {
                side1 = value;
            }
        }
        public double Side2
        {
            get { return side2; }
            set
            {
                side2 = value;
            }
        }
        public bool Verification(double side1, double side2)
        {
            if (side1 == side2)
                return true;
            else
                return false;
        }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double Perimetr(double side1, double side2)
        {
            double perimetr;
            perimetr = (side1 + side2) * 2;
            return perimetr;
        }

        public double Square(double side1, double side2)
        {
            double square;
            square = side1 * side2;
            return square;
        }

        public void GetInfo()
        {
            if (Verification(side1, side2) == true)
            {
                Console.WriteLine("Информация о квадрате: ");
                Console.WriteLine($"Сторона квадрата={side1}");
            }
            else
            {
                Console.WriteLine("Информация о прямоугольнике: ");
                Console.WriteLine($"Первая сторона прямоугольника={side1}");
                Console.WriteLine($"Вторая сторона прямоугольника={side2}");
            }
            Console.WriteLine($"Периметр={Perimetr(side1, side2)}");
            Console.WriteLine($"Площадь={Square(side1, side2)}");
        }
    }
}