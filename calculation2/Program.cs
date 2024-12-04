using System;
namespace calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // copied from "calculation" within the same folder
            // instructions:
            // 1. Modify the program to allow the user to try again if they enter invalid input.
            // 2. Extend the program to calculate the volume of a sphere (Volume = 4/3 × π × r³) 
            // using the radius and PI inputs

            // using single method for easier understanding

            Console.WriteLine("Enter the radius (r): ");
            string? rText=Console.ReadLine();
            Console.WriteLine("Enter value of pi: ");
            string? piText=Console.ReadLine();
            Console.WriteLine("Total calculation: ");

            if (double.TryParse(rText, out double r) && double.TryParse(piText, out double pi))
            {
                double areaOfCircle=pi*r*r;
                double circumCircle=2*pi*r;
                // adding volume calculation provided in line 12
                // dots have to be used to provide proper volume calculation otherwise it'll give an incorrect answer
                double volumeOfSphere=4.0/3.0*pi*r*r*r; //it matters little if numbers are wrapped in parenthesis, result is same

                // $@ means multiple lines of strings
                Console.WriteLine($@"
                Circle calculations:
                Radius: {r}, Pi: {pi}
                Area: {areaOfCircle}
                Circumference: {circumCircle}
                Volume is: {volumeOfSphere}
                "); // pi must be written with comma rather than a dot (based on localization)
            }
            else
            {
                Console.WriteLine("Invalid input, try again");
            }           
        }

    }
}