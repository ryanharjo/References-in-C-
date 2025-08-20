using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Harjo_Ryan
{
    // Define an internal interface named IAutomobile.
    // Interfaces specify what members a class must implement, but not how they work.
    internal interface IAutomobile
    {
        // Read-only property representing the speed of the automobile.
        // Any class that implements this interface must provide a way to get the speed.
        public double Speed { get; }

        // Read-only property representing the number of wheels.
        public int Wheels { get; }

        // Read-only property representing the license plate of the automobile.
        public string LicensePlate { get; }

        // Method that outputs the automobile's details as a string.
        public void Stringify();


    }
}
