using System;

namespace Syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //interchange the content 
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = a;
            //a = b;
            //b = c;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //first grade ec 
            int ap = int.Parse(Console.ReadLine()); 
          
            if (ap == 0)
            {
                Console.WriteLine("Param a can't be 0");
                ap = int.Parse(Console.ReadLine());
            }
            int bp = int.Parse(Console.ReadLine());
            int x = -bp / ap;
            Console.WriteLine(x); 
        }
    }
}
