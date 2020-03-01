using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class EasySet
    {
        public static List<int> PositiveNumbers(List<int> numbers)
        {
            List<int> positiveNumber = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
                if (numbers[i] > 0)
                    positiveNumber.Add(numbers[i]);

            return positiveNumber;
        }

        public static List<int> InsertTheNumber(List<int> numbers, int number)
        {
            if (numbers != null)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > 0)
                    {
                        numbers.Insert(i + 1, number);
                        i++;
                    }
                }
            }

            return numbers;
        }

        public static List<int> ConvertToInt(List<string> list)
        {
            List<int> numbers = new List<int>();
            if (list != null)
            {
                for(int i = 0; i < list.Count; i++)
                {
                    if(int.TryParse(list[i], out int x))
                    {
                        numbers.Add(x);
                    }
                }
            }

            return numbers;
        }

        public static List<int> ClearList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
                if (list[i] % 2 == 0)
                {
                    list.RemoveAt(i);
                    i--;
                }

            return list;
        }
    }
}
