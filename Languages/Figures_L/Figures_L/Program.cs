﻿using System;
using Figures_L.Figures;

namespace Figures_L
{
    class Program
    {
        static void Main()
        {
            bool verification;
            int InputData;
            double Side1;
            double Side2;
            double Radius1;
            double Radius2;
            Rectangle rectangle;//создание объекта класса Rectangle
            Ellipse ellipse;//Создание объекта класса Ellipse
            do
            {
                verification = true;
                Console.WriteLine("Вв-де номер фигуры, которая вам необходима");
                try
                {
                    Console.WriteLine("1-Прямоугольник;\n2-Круг;\nДругая цифра-выход.");
                    InputData = Convert.ToInt32(Console.ReadLine());
                    if (InputData == 1)
                    {
                        Console.WriteLine("Вы выбрали прямоугольник.\nВведите его стороны");
                        Console.WriteLine("Вв-те первую сторону прямоугольника");
                        Side1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Вв-те вторую сторону прямоугольника");
                        Side2 = Convert.ToDouble(Console.ReadLine());
                        if(Side1<=0 || Side2<=0 )
                        {
                            throw new Exception("Ридиус должна быть больше или равна нулю");
                        }
                        rectangle = new Rectangle(Side1, Side2);
                        rectangle.GetInfo();
                        Console.WriteLine();
                    }
                    else if (InputData == 2)
                    {
                        Console.WriteLine("Вы выбрали круг.\nВведите его радиусы");
                        Console.WriteLine("Вв-те первый радиус круга");
                        Radius1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Вв-те второй радиус круга");
                        Radius2 = Convert.ToDouble(Console.ReadLine());
                        if (Radius1 <= 0 || Radius2 <= 0)
                        {
                            throw new Exception("Радиус должна быть больше или равна нулю");
                        }
                        ellipse = new Ellipse(Radius1, Radius2);
                        ellipse.GetInfo();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                // Обрабатываем исключение при неккоректном вводе числа в консоль
                catch (FormatException)
                {
                    Console.WriteLine("Это НЕ число!!!\n");
                    Console.WriteLine();
                    Main();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                    Main();
                }
                Console.WriteLine("Хотите повторить?\n1-да;\nДругое число-нет");
                var check = int.Parse(Console.ReadLine());
                if(check==1)
                {
                    Console.Clear();
                }
                else
                {
                    verification = false;
                }
            } while (verification == true);
        }
    }
}