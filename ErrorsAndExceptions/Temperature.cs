using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorsAndExceptions
{
    public class Temperature
    {
        //property
        public int TemperatureInCelsius { get; set; }

        //constructor 
        public Temperature(int temp)
        {
            TemperatureInCelsius = temp;
        }

        //method to display
        public void ShowTemperature()
        {
            if (TemperatureInCelsius == 0)
                throw new TempIsZeroException("Error! Temperature is zero!");
            else
                Console.WriteLine(TemperatureInCelsius);
        }
    }


    public class TempIsZeroException : Exception
    {
        public TempIsZeroException(string message) : base(message)
        {

        }
    }
}
