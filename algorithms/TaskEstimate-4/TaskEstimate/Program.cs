namespace TaskEstimate;

static class Program
{
    private static int[] CreateAndFill(int k)
    {
        int[] mas = new int[k];
        Random rand = new Random();
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = rand.Next(2, 6);
        }

        return mas;
    }

    private static void NormalCase(int[] mas)
    {
        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i] == 2)
                break;
        }
    }

    private static void BestCase(int[] mas)
    {
        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[0] != 2 || mas[0] == 2)
                break;
        }
    }

    private static void WorstCase(int[] mas)
    {
        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i] == 2 && mas.Length - 1 == i)
                break;
        }
    }

    static void Main()
    {
        var n = new List<int> {10000000, 25000000, 50000000, 100000000};
        double timeWork;
        var kol = 5;
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        
        var mas1 = CreateAndFill(1000000);
        NormalCase(mas1);
        foreach (int k in n)
        {
            Console.WriteLine($"----------     Количество элементов массива {k}    ---------- ");
            var mas = CreateAndFill(k);
            timeWork = 0;
            for (int j = 1; j <= kol; j++)
            {
                sw.Reset();
                sw.Start();
                NormalCase(mas);
                sw.Stop();
                timeWork += sw.ElapsedMilliseconds;
            }

            timeWork = timeWork / kol;
            Console.WriteLine($"Время работы среднего алгоритма {timeWork}");

            timeWork = 0;
            for (int j = 1; j <= kol; j++)
            {
                sw.Reset();
                sw.Start();
                BestCase(mas);
                sw.Stop();
                timeWork += sw.ElapsedMilliseconds;
            }

            timeWork /= kol;
            Console.WriteLine($"Время работы эффективного алгоритма  {timeWork}");

            timeWork = 0;
            for (int j = 1; j <= kol; j++)
            {
                sw.Reset();
                sw.Start();
                WorstCase(mas);
                sw.Stop();
                timeWork += sw.ElapsedMilliseconds;
            }

            timeWork /= kol;
            Console.WriteLine($"Время работы не эффективного алгоритма  {timeWork}");
        }

        Console.ReadLine();
    }
}