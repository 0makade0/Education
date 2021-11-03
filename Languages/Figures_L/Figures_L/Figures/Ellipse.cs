using System;

namespace Figures_L.Figures_L
{
    public class Ellipse : IFigure
    {
        public int radius1 { get; set; }
        public int radius2 { get; set; }
        public Ellipse()
        {
            Random random = new Random();
            radius1 = random.Next(1, 4);
            radius2 = random.Next(1, 4);
        }
        public double Perimetr()
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

        public double Square()
        {
            //Что у эллипса, что у круга формулы одинаковы
            return (Math.PI * radius1 * radius2);
        }

        public void GetInfo()
        {
            if (radius1 == radius2)
            {
                Console.WriteLine($"{"Окружность",-19}{$"{radius1}, {radius2}",-11}{Perimetr(),-12}{Square(),-11}");
            }
            else
            {
                Console.WriteLine($"{"Эллипс",-19}{$"{radius1}, {radius2}",-11}{Perimetr(),-12}{Square(),-11}");
            }
        }
    }
}