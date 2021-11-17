using System;

namespace Figures_L.Figures_L
{
    public class Ellipse : IFigure
    {
        public string Name { get; set; }
        public double radius1 { get; set; }
        public double radius2 { get; set; }
        public Ellipse()
        {
            Random random = new Random();
            radius1 = random.Next(1, 4);
            radius2 = random.Next(1, 4);
            if (radius1 == radius2)
            {
                Name = "Окружность";
            }
            else
            {
                Name = "Эллипс";
            }
        }
        public double Perimetr()
        {
            //Проверка на равенство радиусов
            if (radius1 == radius2)
            {
                return Math.Round((2 * Math.PI * radius1),4);
            }
            else
            {
                return Math.Round((2 * Math.PI * Math.Sqrt((radius1 * radius1 + radius2 * radius2) / 2)),4);
            }
        }

        public double Square()
        {
            //Что у эллипса, что у круга формулы одинаковы
            return Math.Round((Math.PI * radius1 * radius2),4);
        }

        public void GetInfo()
        {
            if (radius1 == radius2)
            {
                Console.WriteLine($"{$"{Name}",-19}{$"{radius1}, {radius2}",-11}{Perimetr(),-12}{Square(),-11}");
            }
            else
            {
                Console.WriteLine($"{$"{Name}",-19}{$"{radius1}, {radius2}",-11}{Perimetr(),-12}{Square(),-11}");
            }
        }
    }
}