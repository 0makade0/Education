using System;

namespace Figures_L.Figures
{
    public class Triangle : Calculation, IFigure
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public double side3 { get; set; }
        public Triangle()
        {
            while (true)
            {
                Console.WriteLine("Вы выбрали треугольник");
                Console.WriteLine("Вв-те первую сторону треугольника");
                side1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Вв-те вторую сторону треугольника");
                side2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Вв-те третью сторону треугольника");
                side3 = Convert.ToDouble(Console.ReadLine());
                if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                {
                    Console.WriteLine("Сторона должна быть больше нуля");
                }
                GetInfo();
                Console.WriteLine();
                break;
            }
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
        //Метод, который проверяет, существует ли треугольник
        public bool ExistenceCheck()
        {
            bool Check;
            if (side1 + side2 > side3 && side1 + side3 > side2 && side3 + side2 > side1)
                Check = true;
            else
                Check = false;
            return Check;
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
            if (ExistenceCheck() == true)
            {
                Console.WriteLine("Информация о треугольнике:");
                Console.WriteLine($"Вид треугольника:{Verification()}");
                Console.WriteLine($"Периметр треугольника:{Perimetr()}");
                Console.WriteLine($"Площадь треугольника:{Square()}");
            }
            else
                Console.WriteLine("Треугольник не существует");
        }
    }
}
