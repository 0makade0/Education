using System.Collections.Generic;
using System.Linq;

namespace LinearSort
{
    public static class Sort
    {
        public static int[] CountingSort(int[] array1)
        {
            var max = array1[0];
            var min = array1[0];

            for (int i = 0; i < array1.Length; i++)
            {
                if (max < array1[i]) max = array1[i];
                else if (min > array1[i]) min = array1[i];
            }

            var correct = min != 0 ? -min : 0;
            max += correct;

            var array2 = new int[max + 1];
            for (int i = 0; i < array1.Length; i++)
            {
                array2[array1[i] + correct]++;
            }

            var index = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = 0; j < array2[i]; j++)
                {
                    array1[index] = i - correct;
                    index++;
                }
            }

            return array1;
        }

        public static int[] PigeonholeSort(int[] array)
        {
            var max = array[0];
            var min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i]) max = array[i];
                else if (min > array[i]) min = array[i];
            }

            var size = max - min + 1;

            int[] pigeonholes = new int[size];
            for (int i = 0; i < size; i++)
            {
                pigeonholes[i] = 0;
            }

            for (int i = 0; i < array.Length; i++)
            {
                pigeonholes[array[i] - min]++;
            }

            var index = 0;
            for (int j = 0; j < size; j++)
            {
                while (pigeonholes[j]-- > 0)
                {
                    array[index] = j + min;
                    index++;
                }
            }

            return array;
        }

        public static List<int> BucketSort(params int[] x)
        {
            List<int> sortedArray = new List<int>();

            int numOfBuckets = 10;

            List<int>[] buckets = new List<int>[numOfBuckets];
            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<int>();
            }

            for (int i = 0; i < x.Length; i++)
            {
                int bucket = (x[i] / numOfBuckets);
                buckets[bucket].Add(x[i]);
            }

            for (int i = 0; i < numOfBuckets; i++)
            {
                List<int> temp = InsertionSort(buckets[i]);
                sortedArray.AddRange(temp);
            }

            return sortedArray;
        }

        public static List<int> InsertionSort(List<int> input)
        {
            for (int i = 1; i < input.Count; i++)
            {
                int currentValue = input[i];
                int pointer = i - 1;

                while (pointer >= 0)
                {
                    if (currentValue < input[pointer])
                    {
                        input[pointer + 1] = input[pointer];
                        input[pointer] = currentValue;
                    }
                    else break;
                }
            }

            return input;
        }
        
        public static void countSort(int[] arr, int n, int exp)
        {
            int[] output = new int[n];
            int i;
            int[] count = new int[10];
  
            for (i = 0; i < 10; i++)
                count[i] = 0;
  
            for (i = 0; i < n; i++)
                count[(arr[i] / exp) % 10]++;
  
            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];
  
            for (i = n - 1; i >= 0; i--) {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }
            for (i = 0; i < n; i++)
                arr[i] = output[i];
        }
  
        public static void RadixSort(int[] arr, int n)
        {
            int m = arr.Max();
  
            for (int exp = 1; m / exp > 0; exp *= 10)
                countSort(arr, n, exp);
        }
    }
}