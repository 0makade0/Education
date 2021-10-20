using System;
using Figures_L.Figures;

namespace Figures_L
{
    class Program
    {
        static void Main()
        {
            bool verification;
            int InputData;
            do
            {
                verification = true;
                //Ввод данных пользователем
                Console.WriteLine("Вв-те номер фигуры, которая вам необходима");
                try
                {
                    Console.WriteLine("1-Прямоугольник;\n2-Круг;\n3-Треугольник\nДругая цифра-выход.");
                    InputData = Convert.ToInt32(Console.ReadLine());
                    if (InputData == 1)
                    {
                        Rectangle rectangle = new Rectangle();//создание объекта класса Rectangle
                    }
                    else if (InputData == 2)
                    {
                        Ellipse ellipse = new Ellipse();//Создание объекта класса Ellipse
                    }
                    else if (InputData == 3)
                    {

                        Triangle triangle = new Triangle();//создание объекта класса Triangle
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