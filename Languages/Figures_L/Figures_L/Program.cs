using System;
using Figures_L.Figures;
using System.Collections.Generic;

namespace Figures_L
{
    class Program
    {
        static void Main()
        {
            bool verification;
            int InputData;
            int countFigure;//количество фигур, которые будет высчитываться для пользователя
            List<int> listFigure;
            do
            {
                verification = true;
                //Ввод данных пользователем
                Console.WriteLine("Вв-те количество фигур:");
                countFigure = Convert.ToInt16(Console.ReadLine());
                if(countFigure<=0)
                {
                    Console.WriteLine("Число должно быть больше нуля");
                    Main();
                }
                Console.WriteLine("Вв-те номер фигуры, которая вам необходима");
                try
                {
                    listFigure = new List<int>(countFigure);
                    Console.WriteLine("1-Прямоугольник;\n2-Круг;\n3-Треугольник\nДругая цифра-выход.");
                    InputData = Convert.ToInt32(Console.ReadLine());
                    if (InputData == 1)
                    {
                        for (int i = 0; i < countFigure; i++)
                        {
                            Rectangle rectangle = new Rectangle();//создание объекта класса Rectangle
                            listFigure.Add(rectangle);
                        }
                    }
                    else if (InputData == 2)
                    {
                        for (int i = 0; i < countFigure; i++)
                        {
                            Ellipse ellipse = new Ellipse();//Создание объекта класса Ellipse
                        }
                    }
                    else if (InputData == 3)
                    {
                        for (int i = 0; i < countFigure; i++)
                        {
                            Triangle triangle = new Triangle();//создание объекта класса Triangle
                        }
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                    Console.WriteLine("Хотите повторить?\n1-да;\nДругое число-нет");
                    var check = int.Parse(Console.ReadLine());
                    if (check == 1)
                    {
                        Console.Clear();
                    }
                    else
                    {
                        verification = false;
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
            } while (verification == true);
        }
    }
}