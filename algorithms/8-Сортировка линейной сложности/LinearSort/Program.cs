using System;
using static LinearSort.Sort;

namespace LinearSort
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var arr = new[] { 43, 17, 87, 92, 31, 6, 96, 13, 66, 62, 4 };

            RadixSort(arr, arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}