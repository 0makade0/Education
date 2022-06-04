using System;

namespace TaskOfTheCard_2
{
    public class Kruskal
    {
        static int V = 9;
        static int[] parent = new int[V];
        static int inf = int.MaxValue;

        static int Find(int i)
        {
            while (parent[i] != i)
                i = parent[i];
            return i;
        }

        static void Union(int i, int j)
        {
            int a = Find(i);
            int b = Find(j);
            parent[a] = b;
        }

        public static void KruskalAlgorithm(int[,] cost)
        {
            int minLength = 0, edgeCount = 0;

            for (int i = 0; i < V; i++)
                parent[i] = i;

            while (edgeCount < V - 1)
            {
                int min = inf, a = -1, b = -1;
                for (int i = 0; i < V; i++)
                {
                    for (int j = 0; j < V; j++)
                    {
                        if (Find(i) != Find(j) && cost[i, j] < min)
                        {
                            min = cost[i, j];
                            a = i;
                            b = j;
                        }
                    }
                }

                Union(a, b);
                Console.Write("Ребро {0}: ({1}, {2}), длина: {3} \n", ++edgeCount, a, b, min);
                minLength += min;
            }

            Console.WriteLine("Минимальная длина = {0} \n", minLength);
        }
    }
}