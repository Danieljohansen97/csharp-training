using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class Car : Vehicle
    {
        public int wheels = 4;
        public String make;
        public String model;
        public int year;
        public String color;

        public static int numberOfCars;

        public Car(String make, String model, int year, String color)    
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
            numberOfCars++;
        }

        public override void Go()
        {
            Console.WriteLine("The car is moving!");
        }
        public static void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }

        public void Drive()
        {
            Console.WriteLine("You drive the " + make + " " + model);
        }
        public override string ToString()
        {
            return "This is a " + make + " " + model;
        }
    }
}
