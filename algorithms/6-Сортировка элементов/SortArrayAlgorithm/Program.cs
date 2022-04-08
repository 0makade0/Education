using System;
using System.Configuration;

namespace SortArrayAlgorithm
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array ={5,0,4,1,0,15,25,10,9,8,1};
            Sorts.GnomSort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}