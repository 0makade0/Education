namespace SortArrayAlgorithm
{
    public static class Sorts
    {
        private static void Swap(ref int element1, ref int element2)
        {
            (element1, element2) = (element2, element1);
        }

        private static int ChangeStep(int step)
        {
            step = step * 1000 / 1247;
            return step > 1 ? step : 1;
        }

        public static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var swapFlag = false;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        swapFlag = true;
                    }
                }

                if (!swapFlag)
                {
                    break;
                }
            }

            return array;
        }

        public static int[] ShakerSort(int[] array)
        {
            for (var i = 0; i < array.Length / 2; i++)
            {
                var flag = false;
                for (var j = i; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        flag = true;
                    }
                }

                for (var j = array.Length - 2 - i; j > i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        Swap(ref array[j - 1], ref array[j]);
                        flag = true;
                    }
                }

                if (!flag)
                {
                    break;
                }
            }

            return array;
        }

        public static int[] OddEvenSort(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var flag = false;
                for (var j = 0; j < array.Length - 1; j += 2)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        flag = true;
                    }
                }

                for (var j = 1; j < array.Length - 1; j += 2)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        flag = true;
                    }
                }

                if (!flag)
                {
                    break;
                }
            }
            return array;
        }

        public static int[] ComboSort(int[] array)
        {
            var arrayLength = array.Length;
            var stepChange = arrayLength - 1;
            while (stepChange > 1)
            {
                for (int i = 0; i + stepChange < arrayLength; i++)
                {
                    if (array[i] > array[i + stepChange])
                    {
                        Swap(ref array[i], ref array[i + stepChange]);
                    }
                }

                stepChange = ChangeStep(stepChange);
            }

            BubbleSort(array);
            
            return array;
        }

        public static int[] ChoiseSort(int[] array)
        {
            int k = 0;
            int minInedxElem = 0;
            int maxInedxElem = 0;
            while (k < array.Length - k)
            {
                for (int j = k; j < array.Length - k; j++)
                {
                    if (array[j] < array[minInedxElem])
                    {
                        minInedxElem = j;
                    }

                    if (array[j] > array[maxInedxElem])
                    {
                        maxInedxElem = j;
                    }
                }

                Swap(ref array[k], ref array[minInedxElem]);
                k++;
                Swap(ref array[array.Length - k], ref array[maxInedxElem]);
                maxInedxElem = k;
                minInedxElem = k;
            }
            return array;
        }

        public static int[] InstertSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while (j >= 1 && array[j - 1] > key)
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }

                array[j] = key;
            }
            return array;
        }

        public static int[] ShellSort(int[] array)
        {
            int d = array.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < array.Length; i++)
                {
                    var j = i;
                    while (j >= d && array[j - d] > array[j])
                    {
                        Swap(ref array[j], ref array[j - d]);
                        j -= d;
                    }
                }

                d /= 2;
            }
            return array;
        }

        public static int[] GnomSort(int[] array)
        {
            var i = 1;
            var nextIndex = i + 1;

            while (i < array.Length)
            {
                if (array[i - 1] < array[i])
                {
                    i = nextIndex;
                    nextIndex++;
                }
                else
                {
                    Swap(ref array[i - 1], ref array[i]);
                    i--;
                    if (i == 0)
                    {
                        i = nextIndex;
                        nextIndex++;
                    }
                }
            }
            return array;
        }
    }
}