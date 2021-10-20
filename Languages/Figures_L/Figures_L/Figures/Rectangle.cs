using System;

namespace Figures_L.Figures
{
    public class Rectangle : Calculation, IFigure
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public Rectangle()
        {
            while (true)
            {
                Console.WriteLine("Вы выбрали прямоугольник.\nВведите его стороны");
                Console.WriteLine("Вв-те первую сторону прямоугольника");
                side1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Вв-те вторую сторону прямоугольника");
                side2 = Convert.ToDouble(Console.ReadLine());
                if (side1 <= 0 || side2 <= 0)
                {
                    Console.WriteLine("Сторона должна быть больше нуля");
                }
                GetInfo();
                Console.WriteLine();
                break;
            }
        }
        public string Verification()
        {
            if (side1 == side2)
                return "Квадрат";
            else
                return "Прямоугольнк";
        }
        public override double Perimetr()
        {
            return (side1 + side2) * 2;
        }

        public override double Square()
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