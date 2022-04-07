using System;

namespace Search
{
    public static class FindElement
    {

        public static int LinearSearch(int[] array, int searchElement)
        {
            int i = 0;
            while (i < array.Length - 1 && array[i] != searchElement)
            {
                i++;
            }

            if (array[i] == searchElement)
            {
                return i;
            }

            return -1;
        }

        public static int SearchWithBarrier(int[] array, int searchElement)
        {
            int i = 0;

            while (array[i] != searchElement)
            {
                i++;
            }

            if (i == array.Length-1)
            {
                return -1;
            }

            return i;
        }

        public static int FastLinearSearch(int[] array, int searchElement)
        {
            int i = 0;
            while (array.Length > i)
            {
                if (array[i] == searchElement)
                {
                    return i;
                }
                else if (array[i] > searchElement)
                {
                    return -1;
                }

                i++;
            }

            return -1;
        }

        public static int BinarySearch(int[] array, int searchElement)
        {
            int startRange = 0;
            int endRange = array.Length - 1;
            int result = -1;

            while (startRange <= endRange)
            {
                int middleElemIndex = (endRange + startRange) / 2;

                if (searchElement <= array[middleElemIndex])
                {
                    if (searchElement == array[middleElemIndex])
                    {
                        result = middleElemIndex;
                    }

                    endRange = middleElemIndex - 1;
                }
                else
                    startRange = middleElemIndex + 1;
            }

            return result;
        }

        public static int JumpSearch(int[] array, int searchElement)
        {
            int startRange = 0;
            int step = Convert.ToInt32(Math.Sqrt(array.Length));
            int endRange = step;
            while (endRange < array.Length)
            {
                if (searchElement < array[endRange])
                {
                    for (int i = startRange; i < endRange; i++)
                    {
                        if (searchElement == array[i])
                        {
                            return i;
                        }
                    }

                    return -1;
                }

                startRange += step;
                endRange += step;
            }
            for (int i = startRange; i < array.Length; i++)
            {
                if (searchElement == array[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}