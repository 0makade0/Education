using System;

namespace Search
{
    public static class ArrayGenerator
    {
        private static Random _random = new Random();

        public static int[] Average(int countElements)
        {
            int[] array = new int[countElements];
            for (int i = 0; i < countElements; i++)
            {
                array[i] = _random.Next(0, countElements);
            }

            return array;
        }

        public static int[] Bad(int countElements, int searchElement)
        {
            int[] array = new int[countElements];
            for (int i = 0; i < countElements; i++)
            {
                array[i] = searchElement + 1;
            }

            return array;
        }

        public static int[] LinearWithBarrier(int[] array, int searchElement)
        {
            int[] copyArray=new int[array.Length+1];
            array.CopyTo(copyArray,0);
            copyArray[copyArray.Length-1] = searchElement;
            return copyArray;
        }

    }
}