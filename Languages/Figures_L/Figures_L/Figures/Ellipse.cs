using System;

namespace Figures_L.Figures
{
    public class Ellipse : IFigure
    {
        private double radius1;
        private double radius2;
        public double Radius1
        {
            get { return radius1; }
            set
            {
                radius1 = value;
            }
        }
        public double Radius2
        {
            get { return radius2; }
            set
            {
                radius2 = value;
            }
        }
        public bool Verification(double radius1, double radius2)
        {
            if (radius1 == radius2)
                return true;
            else
                return false;
        }
        public Ellipse(double radius1, double radius2)
        {
            this.radius1 = radius1;
            this.radius2 = radius2;
        }
        //У круга и эллипса разные формулы вычисления периметра
        //Поэтому для вычисления можно использовать два варианта:
        //1.Либо проверка на равенства радиусов и через условные оператор использовать формулы
        //2.Либо для каждой из фигур использовать свой метод.
        public double Perimetr(double radius1, double radius2)
        {
            double Perimetr;
            //Проверка на равенство радиусов
            if (radius1 == radius2)
            {
                Perimetr = 2 * Math.PI * radius1;
            }
            else
            {
                Perimetr = 2 * Math.PI * Math.Sqrt((radius1 * radius1 + radius2 * radius2) / 2);
            }
            return Perimetr;
        }

        public double Square(double raidus1, double radius2)
        {
            double Square;
            //Что у эллипса, что у круга формулы одинаковы
            Square = Math.PI * raidus1 * radius2;
            return Square;
        }

        public void GetInfo()
        {
            if (Verification(radius1, radius2) == true)
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
            Console.WriteLine($"Периметр={Perimetr(radius1, radius2)}");
            Console.WriteLine($"Площадь={Square(radius1, radius2)}");
        }


    }
}
