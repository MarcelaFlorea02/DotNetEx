using System;

namespace CoreCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alpha = 0; // a-Z, A-Z
            int digit = 0; // 0-9
            int chars = 0; //others 
            string input = Console.ReadLine();
            foreach (char c in input)
            {
                if (c >= '0' && c <= '9')
                {
                    digit++;
                }
                else if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')
                {
                    alpha++;
                }
                else
                {
                    chars++;
                }
            }
            Console.WriteLine("alpha" + alpha);
            Console.WriteLine("digits" + digit);
            Console.WriteLine("other" + chars);
           // decimall to binary
            int nr = int.Parse(Console.ReadLine());
            string binary = "";
            while (nr > 0)
            {
                binary = (nr % 2) + binary;
                nr /= 2;
            }
            Console.WriteLine(binary);


            int a = Convert.ToInt32(Console.ReadLine());
            char operation = Convert.ToChar(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Console.WriteLine("{0}+{1}= {2}", a, b, a + b);
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}= {2}", a, b, a - b);
                    break;
                case 'x':
                case '*':
                    Console.WriteLine("{0}x{1}= {2}", a, b, a * b);
                    break;
                case '/':
                    Console.WriteLine("{0}/{1}= {2}", a, b, a / b);
                    break;
                default:
                    Console.WriteLine("Unrecognized character");
                    break;
            }

            float distance;
            float hour, min, sec;

            float timeSec;
            float mps;
            float kph, mph;

            Console.Write("Input distance(metres): ");
            distance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(hour): ");
            hour = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(minutes): ");
            min = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(seconds): ");
            sec = Convert.ToSingle(Console.ReadLine());

            timeSec = (hour * 3600) + (min * 60) + sec;
            mps = distance / timeSec;
            kph = (distance / 1000.0f) / (timeSec / 3600.0f);
            mph = kph / 1.609f;

            Console.WriteLine("Your speed in metres/sec is {0}", mps);
            Console.WriteLine("Your speed in km/h is {0}", kph);
            Console.WriteLine("Your speed in miles/h is {0}", mph);
        }
    }
}
