using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class ArraySort
    {

        public static void BubbleSort(List<int> array)
        {
            if (array == null || array.Count < 2)
            {
                return;
            }

            bool swapDetected;
            while (true)
            {
                swapDetected = false;
                for (int i = 0; i < array.Count - 1; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        int tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                        swapDetected = true;
                    }
                }
                if (!swapDetected)
                {
                    break;
                }
            }
        }

        public static void SelectionSort(List<int> array)
        {
            if (array == null || array.Count < 2)
                return;

            for (int i = 0; i < array.Count; i++)
            {
                int maxIndex = i;
                for (int next = i + 1; next < array.Count; next++)
                    if (array[maxIndex] < array[next])
                        maxIndex = next;

                if (maxIndex != i)
                { 
                    int tmp = array[i];
                    array[i] = array[maxIndex];
                    array[maxIndex] = tmp;
                }
            }
        }
    }
}
