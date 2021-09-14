using System;
using System.Collections.Generic;
using System.Text;

namespace LineComp
{
    class UC2_CompareEqualityOfLines
    {
        public static void CheckEqualityOfLines()
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

            //.Equals method is applicable only on String data types.
            //.Equals method is used to determine whether two String objects have the same value or not.
            if (lengthOfLineOne.Equals(lengthOfLineTwo))
                Console.WriteLine("Both lines are equal in length.");
            else
                Console.WriteLine("lines are not equal in length.");
        }

    }
}
