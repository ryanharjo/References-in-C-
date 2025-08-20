using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Harjo_Ryan
{
    // Define an internal class named Sedan that implements the IAutomobile interface
    internal class Sedan : IAutomobile
    {
        // Public property representing the speed of the sedan.
        // It can be read from outside the class but modified only within the class.
        public double Speed { get; private set; }

        // Public property representing the number of wheels.
        // Always set to 4 for a sedan.
        public int Wheels { get; private set; }

        // Public property for the license plate of the sedan.
        public string LicensePlate { get; private set; }

        // Constructor that initializes a Sedan object with a given speed.
        public Sedan(double speed)
        {
            // All sedans have 4 wheels, set initial speed, and set a default license plate
            Wheels = 4;
            Speed = speed;
            LicensePlate = "GCTC-06";
        }

        // Method that prints a formatted string describing the sedan's state
        public void Stringify()
        {
            Console.WriteLine($"The Sedan is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}.");
        }

        // Method to increase the speed of the sedan by 5 units
        public void IncreaseSpeed()
        {
            Speed += 5;
        }

        // Method to decrease the speed of the sedan by 5 units
        public void DecreaseSpeed()
        {
            Speed -= 5;
        }

    }
}
