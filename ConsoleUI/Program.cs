using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            var car1 = new Car()
            {
                Year = "2016",
                Make = "Chevy",
                Model = "Impala",
                HasTrunk = true,
            };
            vehicles.Add(car1);
            Console.WriteLine("Car One: ");
            Console.WriteLine($"Year: {car1.Year}");
            Console.WriteLine($"Make: {car1.Make}");
            Console.WriteLine($"Model: {car1.Model}");
            Console.WriteLine($"Has a Trunk: {car1.HasTrunk}");
            Console.WriteLine();

            var bike1 = new Motorcycle()
            {
                Year = "2014",
                Make = "Honda",
                Model = "CBR 600",
                HasSideCar = false,
            };
            vehicles.Add(bike1);
            Console.WriteLine("Bike 1: ");
            Console.WriteLine($"Year: {bike1.Year}");
            Console.WriteLine($"Make: {bike1.Make}");
            Console.WriteLine($"Model: {bike1.Model}");
            Console.WriteLine($"Has a Side Car: {bike1.HasSideCar}");
            Console.WriteLine();

            Vehicle vehicle1 = new Car()
            {
                Year = "2022",
                Make = "Honda",
                Model = "Civic",
                HasTrunk = true,
            };
            vehicles.Add(vehicle1);
            Console.WriteLine("Car 2: ");
            Console.WriteLine($"Year: {vehicle1.Year}");
            Console.WriteLine($"Make: {vehicle1.Make}");
            Console.WriteLine($"Model: {vehicle1.Model}");
            Console.WriteLine();
            vehicle1.DriveAbstract();
            vehicle1.DriveVirtual();
            Console.WriteLine();

            Vehicle vehicle2 = new Motorcycle()
            {
                Year = "2020",
                Make = "Harley Davidson",
                Model = "Sportster",
                HasSideCar = false,
            };
            vehicles.Add(vehicle2);
            Console.WriteLine("Bike 2: ");
            Console.WriteLine($"Year: {vehicle2.Year}");
            Console.WriteLine($"Make: {vehicle2.Make}");
            Console.WriteLine($"Model: {vehicle2.Model}");
            Console.WriteLine();
            vehicle2.DriveAbstract();
            vehicle2.DriveVirtual();
            Console.WriteLine();

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine();
            }
            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
