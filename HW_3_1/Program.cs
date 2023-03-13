using System;
using System.Collections.Generic;
using System.Linq;


namespace HW_3_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(21);
            list.Add(42);
            list.Add(15);
            list.Add(18);
            list.Add(19);
            list.Add(20);

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            numbers.Remove(x => x % 2 == 0);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


            List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5 };
            numbers.RemoveAt(2);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            List<int> numbers2 = new List<int> { 18, 21, 38, 47, 55, 66, 31, };
            numbers.Sort((x, y) => x.CompareTo(y));

            foreach (var number in numbers)
                Console.WriteLine(number);

            List<int> numbers3 = new List<int> { 97, 98, 99 };
            IEnumerable<int> moreNumbers = new List<int> { 100, 101, 102 };
            numbers.AddRange(moreNumbers);

            foreach (var number in numbers)
                Console.WriteLine(number);

        }
    }
}