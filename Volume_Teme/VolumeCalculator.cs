using System;

namespace Volume_Teme
{
    class VolumeCalculator
    {
        static void Main(string[] args)
        {
            volume(2);              //  CUBE
            volume(3.3);            //  SPHERE
            volume(2, 3);           //  PYRAMID
            volume(2.3, 2);         //  CYLINDER
            volume(2.2, 2.2);       //  TORUS


        }

        // Calculates the volume of the CUBE
        static void volume (int radius)
        {
            double volume = Math.Pow(radius, 3);
            Console.WriteLine("The volume of the cube is : {0}.", volume);
        }

        // Calculates the volume of the SPHERE
        static void volume(double radius)
        {
            double volume = (4.0/3.0) * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine("The volume of the sphere is : {0}.", volume);
        }

        // Calculates the volume of the PYRAMID
        static void volume(int height, int baseLength)
        {
            double volume = height * Math.Pow(baseLength, 2) / 3;
            Console.WriteLine("The volume of the pyramid is : {0}.", volume);
        }

        // Calculates the volume of the CYLINDER
        static void volume(double radius, int height)
        {
            double volume = Math.Pow(radius, 2) * Math.PI * height;
            Console.WriteLine("The volume of the cylinder is : {0}.", volume);
        }
        
        // Calculates the volume of the TORUS
        static void volume(double minorRadius, double majorRadius)
        {
            double volume = (Math.Pow(minorRadius, 2) * Math.PI) * (2 * Math.PI * majorRadius);
            Console.WriteLine("The volume of the torus is : {0}.", volume);
        }
    }

}
