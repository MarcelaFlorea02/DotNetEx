using System;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string firstName = "John";
            string lastName = "Doe";

            string name = firstName + " " + lastName;

            Console.WriteLine("The first name is {0} and the last name is {1}", firstName, lastName);
            Console.WriteLine("The name is " + name);
            Console.WriteLine(String.Concat(firstName, " ", lastName));

            var url = "uav.ro/info/an3"; 

            var split = url.Split('/');

            Console.ReadLine();
        }
    }
}
