using System;
using System.Collections.Generic;

namespace Vehicle_Management_System
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Vehicle> vehicles = new List<Vehicle>();


            vehicles.Add(new Car { Brand = "Lada", Model = "Granta", Year = 2020, NumberOfDoors = 4 });
            vehicles.Add(new Motorcycle { Brand = "Harley-Davidson", Model = "Sportster", Year = 2019, HasSidecar = false });
            vehicles.Add(new Car { Brand = "BMW", Model = "X5", Year = 2021, NumberOfDoors = 5 });
            vehicles.Add(new Motorcycle { Brand = "Yamaha", Model = "YZF-R3", Year = 2022, HasSidecar = true });

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.StartEngine());
                vehicle.DisplayInfo();
                Console.WriteLine();
            }
        }
    }

    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public virtual string StartEngine()
        {
            return "Vehicle engine started.";
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}");
        }
    }


    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public override string StartEngine()
        {
            return "Car engine started.";
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        }
    }


    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public override string StartEngine()
        {
            return "Motorcycle engine started.";
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Has Sidecar: {HasSidecar}");
        }
    }




}