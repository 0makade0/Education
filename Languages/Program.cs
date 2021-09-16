using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            int a, b, c, d, e, f;
        m1: m: Console.Write("Вв-те четырёхзначное число(a):");
            a = Convert.ToInt32(Console.ReadLine());
            f = 0;
            if (a > 999 && a < 10000 || a < -999 && a > -10000) ;
            else
            {
                Console.WriteLine("Число не является четырёхзначным");
                goto m1;
            }
            a = Math.Abs(a);
            b = a / 1000;
            c = a / 100 % 10;
            d = a / 10 % 10;
            e = a % 10;
            if (b == c && c == d && d == e)
            {
                Console.WriteLine("Постоянная");
                f = 1;
            }
            else if (b >= c && c >= d && d >= e)
            {
                if (b > c && c > d && d > e)
                {
                    Console.WriteLine("Убывающая");
                    f = 1;
                }
                else
                {
                    Console.WriteLine("Невозрастающая");
                    f = 1;
                }
            }
            else if (b <= c && c <= d && d <= e)
            {
                if (b < c && c < d && d < e)
                {
                    Console.WriteLine("Возрастающая");
                    f = 1;
                }
                else
                {
                    Console.WriteLine("Неубывающая");
                    f = 1;
                }
            }
            if (f == 0)
            {
                Console.WriteLine("Нет последовательности");
            }
            Console.WriteLine("Повторить? 1-Да; Любое другое число-нет.");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
                goto m;
             Console.ReadLine();
        }
    }
}