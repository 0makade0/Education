using System;
using System.Diagnostics;

namespace Search
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arraysLengths = {1_000_000, 2_000_000, 3_000_000, 4_000_000, 5_000_000};

            foreach (var arrayLength in arraysLengths)
            {
                int searchElement = arrayLength / 2;
                int[] array;

                Console.WriteLine($"Средний случай - {arrayLength}, ищем {searchElement}");
                array = ArrayGenerator.Average(arrayLength);
                Find(array, searchElement);

                Console.WriteLine($"Худший случай - {arrayLength}, ищем {searchElement}");
                array = ArrayGenerator.Bad(arrayLength, searchElement);
                Find(array, searchElement);

                Console.WriteLine();
            }
        }

        public static void Find(int[] array, int searchElement)
        {
            int Index;
            double workTime;

            workTime = CustomStopwatch(FindElement.LinearSearch, array, searchElement, out Index);
            Console.WriteLine($"Линейный\tИндекс:\t{Index}\t\tВремя:\t{workTime}");
                
            int[] arrayWithBarrier = ArrayGenerator.LinearWithBarrier(array, searchElement);
            workTime = CustomStopwatch(FindElement.SearchWithBarrier, arrayWithBarrier, searchElement, out Index);
            Console.WriteLine($"C барьером\tИндекс:\t{Index}\t\tВремя:\t{workTime}");

            Array.Sort(array);
            
            workTime = CustomStopwatch(FindElement.BinarySearch, array, searchElement, out Index);
            Console.WriteLine($"Бинарный\tИндекс:\t{Index}\t\tВремя:\t{workTime}");
            
            workTime = CustomStopwatch(FindElement.FastLinearSearch, array, searchElement, out Index);
            Console.WriteLine($"Быстрый\tИндекс:\t{Index}\t\tВремя:\t{workTime}\n");
            
            workTime = CustomStopwatch(FindElement.JumpSearch, array, searchElement, out Index);
            Console.WriteLine($"Прыжковый\tИндекс:\t{Index}\t\tВремя:\t{workTime}\n");
        }
        
        private static double CustomStopwatch(Func<int[], int, int> method, int[] array, int numberToFind, out int result)
        {
            Stopwatch stopwatch = new Stopwatch();
            double workTime = 0;
            
            stopwatch.Start();
            result = method(array, numberToFind);
            stopwatch.Stop();
            workTime += stopwatch.ElapsedMilliseconds;

            return workTime;
        }
    }
}
