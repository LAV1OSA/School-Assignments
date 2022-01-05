using System;

namespace Dahuyag_JK_ACT04E
{
    class Program
    {
        static void Main(string[] args)
        {
            // setting up the variables
            string heightinput, radiusinput, unit;
            int radius, height;

            // the program asks for the dimensions of the cylinder
            Console.WriteLine("Enter the height of the cylinder:");
            heightinput = Console.ReadLine();
            Console.WriteLine("Enter the radius of the cylinder:");
            radiusinput = Console.ReadLine();
            Console.WriteLine("Enter the unit of the dimensions:");
            unit = Console.ReadLine();

            // the program converts the input into integer data types
            radius = Convert.ToInt32(radiusinput);
            height = Convert.ToInt32(heightinput);

            // the program computes the surface area of the cylinder
            double SurfaceAreaOfCircle = 2 * Math.Pow(radius, 2) * Math.PI + 2 * Math.PI * radius * height;
            Console.WriteLine("\nSurface Area of Cyliner:" +
                "\nSA = (2 *pi *r *r) + (2 * pi * r * h)" +
                "\nSA = (2 * " + Math.PI + " * " + Math.Pow(radius,2) + ") + (2 * " + Math.PI + " * " + radius + " * " + height + ")" +
                "\nSA = " + SurfaceAreaOfCircle + " sq. " + unit);

            Console.WriteLine("\nThe surface area of a cylinder with height of " + height + " and radius of " + radius + " is equal to: " + SurfaceAreaOfCircle + " sq. " + unit);

            // the program computes the volume of the cylinder
            double VolumeOfCircle = Math.Pow(radius, 2) * Math.PI * height;
            Console.WriteLine("\nVolume of Cylinder:" +
                "\nV = pi * r * r * h" +
                "\nV = " + radius + " * " + radius + " * " + Math.PI + " * " + height +
                "\nV = " + VolumeOfCircle + " cubic " + unit);

            Console.WriteLine("\nThe volume of a cylinder with height of " + height + " and radius of " + radius + " is equal to: " + VolumeOfCircle + " cubic " + unit);
        } 
    }
}
