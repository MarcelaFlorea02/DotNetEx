using System;

namespace GenericsSwap
{
    public class Program
    {
        static void Main(string[] args)
        {
            int nr1 = 10;
            int nr2 = 20;
            SwapClass swapClass = new SwapClass();
            var result = swapClass.Swap(nr1, nr2);
            Console.WriteLine("Nr1=" + result.Item1);
            Console.WriteLine("Nr2=" + result.Item2);

            string str1 = "abc";
            string str2 = "def";

            var result2 = swapClass.Swap(str1, str2);
            Console.WriteLine("Str1=" + result2.Item1);
            Console.WriteLine("Str2=" + result2.Item2);

        }
    }

    public class SwapClass
    {
        public Tuple<T, T> Swap<T>(T a, T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;

            return Tuple.Create<T, T>(a, b);
        }
    }
}
