using System;
using System.Text.RegularExpressions;

namespace RegexExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prop = "She is nice2.";
            var result = AlmostOnlyLetters(prop);
            Console.WriteLine(result);
        }

        public static bool AlmostOnlyLetters(string sentence)
        {
            Regex regex = new Regex(@"^[A-Za-z\s]+\.$");
            var match = regex.IsMatch(sentence);
            return match;
        }
    }
}
