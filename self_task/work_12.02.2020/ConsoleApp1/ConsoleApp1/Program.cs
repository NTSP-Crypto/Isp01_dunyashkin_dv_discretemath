using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int> { -15, 34, -26, 20, -12, 0, 14, 88, 0 };

            ArraySort.BubbleSort(array);
            Console.WriteLine("После сортировки: ");
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            ArraySort.SelectionSort(array);
            for(int i = 0; i < array.Count; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.ReadKey();
        }
    }
}
