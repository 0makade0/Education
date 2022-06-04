using System;

namespace TaskOfTheCards_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var graph = new Graph();
            for (int i = 0; i <= 8; i++)
                graph.AddVertex(i.ToString());
            
            graph.AddEdge("0", "4", 14);
            graph.AddEdge("0", "5", 20);
            graph.AddEdge("4", "6", 10);
            graph.AddEdge("1", "6", 12);
            graph.AddEdge("1", "3", 11);
            graph.AddEdge("1", "2", 3);
            graph.AddEdge("1", "8", 3);
            graph.AddEdge("6", "8", 7);
            graph.AddEdge("7", "8", 8);
            graph.AddEdge("2", "7", 1);
            graph.AddEdge("2", "5", 10);
            graph.AddEdge("3", "7", 5);
            graph.AddEdge("3", "5", 9);
            
            var dijkstra = new Dijkstra(graph);
            var path = dijkstra.FindShortestPath("4", "3");
            Console.WriteLine($"Кратчайший путь по алгоритму Дейкстры: {path}");

            Console.ReadKey();
        }
    }
}