using System;
using System.Collections.Generic;

namespace Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////read from keyboard two numbers 
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int sum = a + b;
            //Console.WriteLine("The sum of the two numbers {0} and {1} is {2}", a, b, sum);
            List<int> numbers = new List<int>();
            int number = int.Parse(Console.ReadLine());
            //numbers.Add(number);
            if (number % 100 == 0)
            {

                Console.WriteLine("Number ends in 0");

                return;
            }
            else
            {
                while (number % 100 != 0)
                {
                    numbers.Add(number);
                    number = int.Parse(Console.ReadLine());

                }
            }
            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }

        }

        private static void DisplayNumbers(List<int> numbers)
        {
            foreach (int n in numbers)
            {
                Console.Write(n + ",");
            }
        }
    }
}

