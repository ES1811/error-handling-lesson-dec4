using System;
namespace calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is basically copied from the .pdf file sent by teacher lol
            Console.WriteLine("Enter the radius (r): ");
            string? rText=Console.ReadLine();
            Console.WriteLine("Enter value of pi: ");
            string? piText=Console.ReadLine();

            if (double.TryParse(rText, out double r) && double.TryParse(piText, out double pi))
            {
                double areaOfCircle=pi*r*r;
                double circumCircle=2*pi*r;

                //have to use comma for pi rather than a dot

                Console.WriteLine($@"
                Circle calculations:
                Radius: {r}, Pi: {pi}
                Area: {areaOfCircle}
                Circumference: {circumCircle}
                ");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }           
        }

    }
}