using System;

namespace ErrorsAndExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Temperature temp = new Temperature(0);
                temp.ShowTemperature();
            }
            catch (TempIsZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
