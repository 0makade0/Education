namespace TaskEstimate;

static class Program
{
    //алгоритм заполнения массива
    private static int[] CreateArr(int countElem, Case choiseCase)
    {
        var array = new int[countElem];
        var rand = new Random();
        if (choiseCase == Case.Best)
        {
            array[0] = 2;
            for (int i = 1; i < array.Length; i++)
            {
                array[i] = rand.Next(3, 6);
            }
        }
        else if (choiseCase == Case.Normal)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(2, 6);
            }
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(3, 6);
            }
        }

        return array;
    }

    //Алгоритм поиска нужной нам оценки
    private static bool CheckArray(int[] array)
    {
        bool checkElem = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == 2)
            {
                checkElem = true;
                break;
            }
        }

        return checkElem;
    }

    //Алгоритм секундомера
    private static double TimeCheck(int kol, int countElem, Case choiseCase)
    {
        double timeWork = 0;
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        for (int j = 1; j <= kol; j++)
        {
            var array = CreateArr(countElem, choiseCase);
            sw.Reset();
            sw.Start();
            var check = CheckArray(array);
            sw.Stop();
            timeWork += sw.ElapsedMilliseconds;
        }

        timeWork /= kol;
        return timeWork;
    }

    static void Main()
    {
        var n = new List<int> {10000000, 25000000, 50000000, 100000000};
        var kol = 3;
        TimeCheck(kol, 1000000, Case.Best);

        foreach (int k in n)
        {
            Console.WriteLine($"----------     Количество элементов массива {k}    ---------- ");
            Console.WriteLine($"Время работы лучшего алгоритма {TimeCheck(kol, k, Case.Best)}");
            Console.WriteLine($"Время работы среднего алгоритма {TimeCheck(kol, k, Case.Normal)}");
            Console.WriteLine($"Время работы не эффективного алгоритма  {TimeCheck(kol, k, Case.Worst)}");
        }

        Console.ReadLine();
    }
}