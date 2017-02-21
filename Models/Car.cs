using System;
using System.Collections.Generic;

namespace Program_1.Models
{
    public class Car
    {
        public double speed {get; protected set;} = 100;
        public double acceleration {get; protected set;} = 10;

        public void Start()
        {
            Console.WriteLine("Turning on the engine...");
            Console.WriteLine($"Running at: {speed} km/h.");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping the car...");
        }

        public virtual void Accelerate()
        {
            System.Console.WriteLine("Accelerateing...");
            speed += acceleration;
            Console.WriteLine($"Running at: {speed} km/h.");
        }
    }

    public class Truck : Car
    {
        public override void Accelerate()
        {
            System.Console.WriteLine("Accelerateing a truck...");
            speed += acceleration;
            Console.WriteLine($"Running the truck: {speed} km/h.");
        }
    }

    public class SportCar : Car
    {
        public override void Accelerate()
        {
            System.Console.WriteLine("Accelerateing a sport car...");
            speed += acceleration;
            Console.WriteLine($"Running the sport car at: {speed} km/h.");
        }
    }

    public class Race
    {
        public void Begin()
        {
            SportCar sportCar = new SportCar();
            Truck truck = new Truck();

            

            List<Car> cars = new List<Car>
            {
                sportCar, truck
            };

            foreach (Car car in cars)
            {
                car.Start();
                car.Accelerate();
            }
        }
    }
}