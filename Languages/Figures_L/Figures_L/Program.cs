using System;
using Figures_L.Figures_L;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Figures_L
{
    class Program
    {
        static void Main()
        {
            bool verification;
            int InputData;
            List<IFigure> figures = new List<IFigure>(10);
            IFigure figure;
            do
            {
                verification = true;
                //Ввод данных пользователем  
                Console.WriteLine("Вв-те номер фигуры, которая вам необходима");
                try
                {
                    Console.WriteLine("1-Прямоугольник;\n2-Круг;\n3-Треугольник");
                    InputData = Convert.ToInt32(Console.ReadLine());
                    while (figures.Count != 10)
                    {
                        switch (InputData)
                        {
                            case 1:
                                figure = new Rectangle();
                                break;
                            case 2:
                                figure = new Ellipse();
                                break;
                            default:
                                figure = new Triangle();
                                break;
                        }
                        figures.Add(figure);
                    }
                    // Вывод первоначального списка
                    Console.WriteLine("Первоначальный список");
                    if (InputData == 3)
                    {
                        Console.WriteLine($"{"Название",-19}{"Стороны",-11}{"Периметр",-12}{"Площадь",-11}{"Вид треугольника",-20}");
                    }
                    else
                        Console.WriteLine($"{"Название",-19}{"Стороны",-11}{"Периметр",-12}{"Площадь",-11}");
                    foreach (IFigure f in figures)
                    {
                        f.GetInfo();
                    }
                    figures = figures.OrderBy(x => x.Perimetr()).ToList();
                    IEnumerator ie = figures.GetEnumerator();
                    // Вывод отсортированного списка с помощью foreach
                    Console.WriteLine("\nОтсортированный список (foreach)");
                    if (InputData == 3)
                    {
                        Console.WriteLine($"{"Название",-19}{"Стороны",-11}{"Периметр",-12}{"Площадь",-11}{"Вид треугольника",-20}");
                    }
                    else
                        Console.WriteLine($"{"Название",-19}{"Стороны",-11}{"Периметр",-12}{"Площадь",-11}");
                    foreach (IFigure item in figures)
                    {
                        item.GetInfo();
                    }
                    // Вывод отсортированного списка с помощью while
                    Console.WriteLine("\nОтсортированный список (while)");
                    if(InputData==3)
                    {
                        Console.WriteLine($"{"Название",-19}{"Стороны",-11}{"Периметр",-12}{"Площадь",-11}{"Вид треугольника",-20}");
                    }
                    else
                        Console.WriteLine($"{"Название",-19}{"Стороны",-11}{"Периметр",-12}{"Площадь",-11}");
                    while (ie.MoveNext())
                    {
                        figure = (IFigure)ie.Current;
                        figure.GetInfo();
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