using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:
            
            var numbers = new int[10] {1,2,3,4,5,6,7,8,9,10};
            var evens = new List<int>();
            var odds = new List<int>();
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evens.Add(number);
                }
                else
                {
                    odds.Add(number);
                }
            }

            foreach (var number in evens)
            {
                Console.WriteLine(number);
            }

            for (int i = 0; i < odds.Count; i++)
            {
                Console.WriteLine(odds[i]);
            }
        }
    }
}
