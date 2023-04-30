using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample
{
    public class Car
    {
        //field 
        private string model;
        //property for field 
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        // or auto-implemented property 
        //public string Model { get; set; }
        public int Speed { get; set; }
        //constructor
        public Car()
        {

        }
        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }
        public Car(string model) : this(model, 20)
        {

        }

        //method 
        public void AccSpeed(int speedIncrement)
        {
            Speed = Speed + speedIncrement;
            // Speed += speedIncrement; 
        }
    }

    //extensions method 
    public static class CarExtensions
    {
        public static decimal CalculateDistance(this Car car, int time)
        {
            // d= v* t 
            var d = car.Speed * time;
            return d; 
            // return car.Speed * time; 
        }
    }
}
