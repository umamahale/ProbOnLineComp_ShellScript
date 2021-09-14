using System;
using System.Collections.Generic;
using System.Text;

namespace LineComp
{
    class UC3_CompareTwoLines
    {
        public static void CompareTwoLines()
        {

            Console.WriteLine("******Please Enter Coordinates for First Line L1******");

            Console.WriteLine("Please Enter Coordinates for first point as X & Y");
            int pointX1L1 = Convert.ToInt32(Console.ReadLine());
            int pointY1L1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Coordinates for second point as X & Y");
            int pointX2L1 = Convert.ToInt32(Console.ReadLine());
            int pointY2L1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("******Please Enter Coordinates for Second Line L2******");

            Console.WriteLine("Please Enter Coordinates for first point as X & Y");
            int pointX1L2 = Convert.ToInt32(Console.ReadLine());
            int pointY1L2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Coordinates for second point as X & Y");
            int pointX2L2 = Convert.ToInt32(Console.ReadLine());
            int pointY2L2 = Convert.ToInt32(Console.ReadLine());

            double lengthOfL1 = Math.Sqrt((Math.Pow((pointX2L1 - pointX1L1), 2) + Math.Pow((pointY2L1 - pointY1L1), 2)));
            Console.WriteLine("Length of Line1 as per provided points is: " + lengthOfL1 + " units.");
            string lengthOfLineOne = Convert.ToString(lengthOfL1); //converting data type of variable from double to String so that we can compare using EQUAL function

            double lengthOfL2 = Math.Sqrt((Math.Pow((pointX2L2 - pointX1L2), 2) + Math.Pow((pointY2L2 - pointY1L2), 2)));
            Console.WriteLine("Length of Line2 as per provided points is: " + lengthOfL2 + " units.");
            string lengthOfLineTwo = Convert.ToString(lengthOfL2); //converting data type of variable from double to String so that we can compare using EQUAL function


            int status = lengthOfLineOne.CompareTo(lengthOfLineTwo);

            if (status > 0) // if lengthOfLineOne > lengthOfLineTwo, it returns positive number
                Console.WriteLine("First line L1 is greater than Second Line L2.");
            else if (status < 0) //if lengthOfLineOne < lengthOfLineTwo, it returns negative number
                Console.WriteLine("Second line L2 is greater than First Line L1.");
            else
                Console.WriteLine("Both lines are equal in length.");
        }
    

}
}
