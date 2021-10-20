using System;

namespace Figures_L.Figures
{
    public class Ellipse : Calculation, IFigure
    {
        public double radius1 { get; set; }
        public double radius2 { get; set; }
        public Ellipse()
        {
            while (true)
            {
                Console.WriteLine("Вы выбрали круг.\nВведите его радиусы");
                Console.WriteLine("Вв-те первый радиус круга");
                radius1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Вв-те второй радиус круга");
                radius2 = Convert.ToDouble(Console.ReadLine());
                if (radius1 <= 0 || radius2 <= 0)
                {
                    Console.WriteLine("Радиус должен быть больше нуля");
                    continue;
                }
                GetInfo();
                Console.WriteLine();
                break;
            }
        }
        public string Verification()
        {
            if (radius1 == radius2)
                return "Круг";
            else
                return "Эллипс";
        }
        //У круга и эллипса разные формулы вычисления периметра
        //Поэтому для вычисления можно использовать два варианта:
        //1.Либо проверка на равенства радиусов и через условные оператор использовать формулы
        //2.Либо для каждой из фигур использовать свой метод.
        public override double Perimetr()
        {
            //Проверка на равенство радиусов
            if (radius1 == radius2)
            {
                return (2 * Math.PI * radius1);
            }
            else
            {
                return (2 * Math.PI * Math.Sqrt((radius1 * radius1 + radius2 * radius2) / 2));
            }
        }

        public override double Square()
        {
            //Что у эллипса, что у круга формулы одинаковы
            return (Math.PI * radius1 * radius2);
        }

        public void GetInfo()
        {
            if (Verification() == "Круг")
            {
                Console.WriteLine("Информация о круге: ");
                Console.WriteLine($"Радиус круга={radius1}");
            }
            else
            {
                Console.WriteLine("Информация о эллипсе: ");
                Console.WriteLine($"Первый радиус эллипса={radius1}");
                Console.WriteLine($"Второй радиус эллипса={radius2}");
            }
            Console.WriteLine($"Периметр={Perimetr()}");
            Console.WriteLine($"Площадь={Square()}");
        }
    }
}