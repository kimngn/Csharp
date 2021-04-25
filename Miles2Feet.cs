/*Requirement:
 * Design an application that converts miles to feet.
 * Declare and initialize miles to 4.5
 * Show your miles formatted with 2 positions to the right of the decimal
 * Feet and inches should both be shown with no positions to the right of the decimal
 * Once you get that portion running, modify your solution so that you also show the total
 * number of inches.
 * Go to your source code and change the initializatin value for miles. Rerun the application
 *  1 mile = 5280 feet
 *  1 mile = 63360 inches
 * */




using System;

namespace Miles2Feet_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            //double miles = 4.5f;
            const int feets_ratio = 5280;
            const int inches_ratio = 63360;
            Console.WriteLine("Please enter the mile to convert to feet: ");
            string milesText = Console.ReadLine();
            bool isValidMile = double.TryParse(milesText, out double miles);
            if (isValidMile == true)
            {
                double feet = miles * feets_ratio;
                double inches = miles * inches_ratio;

                Console.WriteLine($"The result is in feets is {feet}");
                Console.WriteLine($"The result is in inches is {inches}"); 
            }
            else
            {
                Console.WriteLine("The input is invalid");
            }



            Console.ReadLine();
        }
    }
}
