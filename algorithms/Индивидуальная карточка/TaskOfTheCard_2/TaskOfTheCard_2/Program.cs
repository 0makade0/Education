using System;

namespace TaskOfTheCard_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int inf = int.MaxValue;

            int[,] cost =
            {
                {inf, inf, inf, inf, 12, inf, 15, inf, 20},
                {inf, inf, 2, 5, inf, inf, inf, inf, 25},
                {inf, 2, inf, inf, inf, inf, inf, inf, 5},
                {inf, 5, inf, inf, inf, 9, inf, 4, inf},
                {12, inf, inf, inf, inf, inf, 10, inf, inf},
                {inf, inf, inf, 9, inf, inf, inf, inf, 11},
                {15, inf, inf, inf, 10, inf, inf, inf, 7},
                {inf, inf, inf, 4, inf, inf, inf, inf, 8},
                {20, 25, 5, inf, inf, 11, 7, 8, inf},
            };

            Console.WriteLine("Алгоритм Краскала: ");
            Kruskal.KruskalAlgorithm(cost);

            Console.WriteLine("Алгоритм Прима: ");
            Prim.PrimAlgorithm(cost);

            Console.ReadKey();
        }
    }
}