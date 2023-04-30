using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample
{
    public static class CarHelper
    {
        public static List<string> GetListOfAvailableModels()
        {
            var availableModels = new List<string>() { "Volvo", "Audi", "Dacia" };
            return availableModels;
        }
    }
}
