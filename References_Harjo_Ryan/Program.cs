namespace References_Harjo_Ryan
{
    // Define the Program class containing the application's entry point
    internal class Program
    {
        // Main method: Entry point of the application
        static void Main(string[] args)
        {
            // Create a new Sedan object with initial speed 0
            Sedan myFirstSedan = new Sedan(0);
            // Assign the same Sedan object to an IAutomobile interface reference
            IAutomobile myAutomobile = myFirstSedan;
            // Create another separate Sedan object with initial speed 0
            Sedan myOtherSedan = new Sedan(0);

            // Increase speed of the first sedan by 5
            myFirstSedan.IncreaseSpeed();
            // Print the speed of the first sedan directly and output is 5
            Console.WriteLine(myFirstSedan.Speed);
            // Print the speed of the sedan through the interface reference and output is 5 (same object)
            Console.WriteLine(myAutomobile.Speed);
            // Check if myFirstSedan and myAutomobile refer to the same object and output is true
            Console.WriteLine(myFirstSedan.Equals(myAutomobile));

            // Increase speed of the second sedan by 5
            myOtherSedan.IncreaseSpeed();
            // Print the speed of both sedans to confirm they're different objects
            Console.WriteLine(myFirstSedan.Speed); // output is 5
            Console.WriteLine(myOtherSedan.Speed); // output is 5
            // Check if the two sedan objects are equal (they are not)
            Console.WriteLine(myFirstSedan.Equals(myOtherSedan));  // output is false

            // Create a new Truck object with speed 50, weight 500, and a custom license plate
            Truck myTruck = new Truck(50, 500, "My Truck");

            // Call Stringify() on each object to print their full description
            myFirstSedan.Stringify(); // Describes the sedan
            myAutomobile.Stringify(); // Same as above (same object)
            myOtherSedan.Stringify(); // Describes the second sedan
            myTruck.Stringify(); // Describes the truck
        }
    }
}
