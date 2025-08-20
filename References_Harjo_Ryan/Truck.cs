using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Harjo_Ryan
{
    // Define a class named Truck
    internal class Truck : IAutomobile
    {
        // Public property representing the truck's speed.
        // Can be read externally, but only modified internally.
        public double Speed { get; private set; }

        // Public property representing the number of wheels.
        // Can be read externally, but only modified internally.
        public int Wheels { get; private set; }

        // Public property representing the license plate.
        // Can be read externally, but only modified internally.
        public string LicensePlate { get; private set; }

        // Read-only public property representing the weight of the truck.
        public double Weight { get; }

        // Constructor to initialize a Truck object with speed, weight, and license plate.
        public Truck(double speedParam, double weightParam, string licenseNum)
        {
            // Initialize properties using constructor parameters
            Speed = speedParam;
            Weight = weightParam;
            LicensePlate = licenseNum;

            // Determine the number of wheels based on the weight of the truck
            if (Weight < 400)
            {
                // Lighter trucks get 8 wheels
                Wheels = 8;
            }
            else
            {
                // Heavier trucks get 12 wheels
                Wheels = 12;
            }
        }

        // Method to print the truck's details to the console in a human-readable format
        public void Stringify()
        {
            Console.WriteLine($"The Truck is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}!");
        }
       
        // Method to increase the speed of the truck by 5 units
        public void IncreaseSpeed()
        {
            Speed += 5;
        }

        // Method to decrease the speed of the truck by 5 units
        public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }
}
