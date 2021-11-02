using System;

namespace Figures_L.Figures
{
    public class Rectangle : IFigure
    {
        public int side1 { get; set; }
        public int side2 { get; set; }
        public Rectangle()
        {
            Random random = new Random();
            side1 = random.Next(1, 3);
            side2 = random.Next(1, 3);
            Console.WriteLine();
        }
        public string Verification()
        {
            if (side1 == side2)
                return "Квадрат";
            else
                return "Прямоугольнк";
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
            if (Verification() == "Квадрат")
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
            Console.WriteLine($"Периметр={Perimetr()}");
            Console.WriteLine($"Площадь={Square()}");
        }
    }
}