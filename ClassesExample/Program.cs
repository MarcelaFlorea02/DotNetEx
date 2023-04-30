using System;

namespace ClassesExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car myCar = new Car();
            //myCar.Model = "Volvo";
            //myCar.Speed = 90;

            //Console.WriteLine("Model of your car is " + myCar.Model);
            //Console.WriteLine("You ride with " + myCar.Speed + "km/h");

            //Car myCar2 = new Car("Audi", 50);

            //Car myCar3 = new Car("Dacia");

            //Console.WriteLine("Speed for Dacia = " + myCar3.Speed);

            //myCar3.AccSpeed(10);

            //Console.WriteLine("Speed after acc is " + myCar3.Speed);

            //var distance = myCar3.CalculateDistance(8);
            //Console.WriteLine(distance);

            var availableModels = CarHelper.GetListOfAvailableModels();

            string model = Console.ReadLine();
            if (!availableModels.Contains(model))
            {
                Console.WriteLine("The model is not available");
            }
            else
            {
                Car myCar4 = new Car(model);
            }
        }
    }
}
