using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers01 = new List<int> { -15, 34, -26, 20, -12, 0, 14, 88, 0 };
            List<int> numbers02 = new List<int> { 5, 72, 6, 1, 35, -11, -1, 47, 1 };
            List<int> numbers03 = new List<int> { 12, 59, -3, 1, 22, -10, 14, 88, 01 };
            List<string> stringNumbers = new List<string> { "00", "32", "KKK", "chislo40" };

            Console.WriteLine(string.Join(", ", EasySet.PositiveNumbers(numbers01)));
            Console.WriteLine(string.Join(", ", EasySet.InsertTheNumber(numbers02, 2004)));
            Console.WriteLine(string.Join(", ", EasySet.ConvertToInt(stringNumbers)));
            Console.WriteLine(string.Join(", ", EasySet.ClearList(numbers03)));

            Console.ReadKey();
        }
    }
}
