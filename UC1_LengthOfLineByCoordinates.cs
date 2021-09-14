using System;
using System.Collections.Generic;
using System.Text;

namespace LineComp
{
    class UC1_LengthOfLineByCoordinates
    {
        public static void LengthOfLineByCoordinates()

        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Console.WriteLine("Please Enter Coordinates for first point as X & Y");
            int pointX1 = Convert.ToInt32(Console.ReadLine());
            int pointY1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Coordinates for first point as X & Y");
            int pointX2 = Convert.ToInt32(Console.ReadLine());
            int pointY2 = Convert.ToInt32(Console.ReadLine());
            double lengthOfLine = Math.Sqrt((Math.Pow((pointX2 - pointX1), 2) + Math.Pow((pointY2 - pointY1), 2)));
            Console.WriteLine("Length of Line as per provided points is: " + lengthOfLine + " units.");

        }

    }
}
