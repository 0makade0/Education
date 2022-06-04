using System;

namespace TaskOfTheCard_2
{
    public class Prim
    {
        static int V = 9;

        static int MinKey(int[] key, bool[] mstSet)
        {
            int min = int.MaxValue, minIndex = -1;

            for (int v = 0; v < V; v++)
                if (mstSet[v] == false && key[v] < min)
                {
                    min = key[v];
                    minIndex = v;
                }

            return minIndex;
        }

        public static void PrimAlgorithm(int[,] graph)
        {
            int[] parent = new int[V];
            int[] key = new int[V];
            bool[] mstSet = new bool[V];
            int minLength = 0;

            for (int i = 0; i < V; i++)
            {
                key[i] = int.MaxValue;
                mstSet[i] = false;
            }

            key[0] = 0;
            parent[0] = -1;

            for (int count = 0; count < V - 1; count++)
            {
                int u = MinKey(key, mstSet);
                mstSet[u] = true;

                for (int v = 0; v < V; v++)
                    if (graph[u, v] != 0 && mstSet[v] == false && graph[u, v] < key[v])
                    {
                        parent[v] = u;
                        key[v] = graph[u, v];
                    }
            }

            for (int i = 1; i < V; i++)
                minLength += graph[i, parent[i]];

            for (int i = 1; i < V; i++)
                Console.Write("Ребро {0}: ({1}, {2}), длина: {3} \n", i, parent[i], i, graph[i, parent[i]]);
            Console.WriteLine("Минимальная длина = {0} \n", minLength);
        }
    }
}