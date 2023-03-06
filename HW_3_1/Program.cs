using System;
using System.Collections.Generic;
using System.Linq;


namespace HW_3_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();
            Console.WriteLine("Метод Add");
            myList.Add("Mersedes");
            myList.Add("BMW");
            myList.Add("Audi");
            myList.Add("Mclaren");



            foreach (string item in myList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===============================");
            Console.WriteLine("Метод Remove");
            myList.Remove("BMW");
            foreach (string item in myList)
            {
               Console.WriteLine(item); 
            }
            Console.WriteLine("==========================");
            Console.WriteLine("Метод RemoveAt");
            myList.Insert(1, "Honda");
            myList.RemoveAt(2);
            foreach (string item in myList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==========================");
            Console.WriteLine("Метод Sort");
            myList.Sort();
            foreach(string item in myList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==========================");
            Console.WriteLine("Метод AddRange");
            string[] socialNetoworksArray = { "YouTube", "Facebook", "Instagram", "Twitter" };
            List<string> socialNetoworks = new List<string>();
            myList.AddRange(socialNetoworks);









        }
    }
}