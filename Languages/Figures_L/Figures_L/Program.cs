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
            do
            {
                List<IFigure> figures = new List<IFigure>(10);
                IFigure figure;
                int InputData;
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



                    bool all1 = figures.All(x => x.Perimetr() > 10);
                    Console.WriteLine($"\nВсе периметры больше 10: {all1}");

                    bool all2 = figures.All(x => x.Perimetr() > 1);
                    Console.WriteLine($"Все периметры больше 1: {all2}");

                    bool any1 = figures.Any(x => x.Perimetr() > 10);
                    Console.WriteLine($"\nХотя бы один периметр больше 10: {any1}");

                    bool any2 = figures.Any(x => x.Perimetr() > 10);
                    Console.WriteLine($"Хотя бы один периметр больше 1: {any2}");

                    double sum1 = figures.Sum(x => x.Perimetr());
                    Console.WriteLine($"\nСумма всех периметров: {sum1}");

                    double sum2 = figures.Sum(x => x.Square());
                    Console.WriteLine($"Сумма всех площадей: {sum2}");

                    double min1 = figures.Min(x => x.Perimetr());
                    Console.WriteLine($"\nМинимальный периметр: {min1}");

                    double min2 = figures.Min(x => x.Square());
                    Console.WriteLine($"Минимальная площадь: {min2}");

                    double max1 = figures.Max(x => x.Perimetr());
                    Console.WriteLine($"\nМаксимальный периметр: {max1}");

                    double max2 = figures.Max(x => x.Square());
                    Console.WriteLine($"Максимальная площадь: {max2}");
                    
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