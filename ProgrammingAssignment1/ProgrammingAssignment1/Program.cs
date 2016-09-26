using System;

namespace ProgrammingAssignment1
{
    class Program
    {
        /// <summary>
        /// Calculate the distance between two points and the angle between them
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            //greeting user
            Console.WriteLine("Welcome.");
            Console.WriteLine("This program will calculate the distance between two points");
            Console.WriteLine("and the angle between those points.");

            //prompt for user input
            Console.Write("First point x value?: ");
            float point1X = float.Parse(Console.ReadLine());
            Console.Write("First point y value?: ");
            float point1Y = float.Parse(Console.ReadLine());
            Console.Write("Second point x value?: ");
            float point2X = float.Parse(Console.ReadLine());
            Console.Write("Second point y value?: ");
            float point2Y = float.Parse(Console.ReadLine());

            //Calculate difference between points 1 and 2
            double deltaX = point2X - point1X;
            double deltaY = point2Y - point1Y;

            //Pythagorean finding hypotenuse
            double hypotenuse = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            //Finding the desired angle
            double angle = Math.Atan2(deltaY , deltaX);

            //radians to degrees
            angle = angle * 57.2958;

            //display results formated to 3 decimal places
            Console.WriteLine("The distance between the two points is " + (hypotenuse.ToString("F3"))+ " units");
            Console.WriteLine("and the angle between the points is " + (angle.ToString("F3")) + " degrees");
            Console.ReadLine();
            
        }
    }
}
