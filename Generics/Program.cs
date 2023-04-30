using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print<int>(200);
            printer.Print<string>("hello");
        }
    }

    public class Printer
    {
        public void Print<T>(T data)
        {
            Console.WriteLine(data.ToString());
        }
    }
}
