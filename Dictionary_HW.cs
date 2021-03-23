using System;
using System.Collections.Generic;

namespace Dictionary_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a Dictionary list of employee IDs and the name that goes with that IDs
            //and the name that goes with that ID. Fill it with a few records.Then ask the user 
            //for their ID and return their name
            Dictionary<int, string> EmployeeNames = new Dictionary<int, string>();
            EmployeeNames[123] = "Kim";
            EmployeeNames[003] = "Sue";
            EmployeeNames[007] = "Bob";

            Console.WriteLine("What is your ID?");
            string IdKeyText = Console.ReadLine();

            bool isValidIdKeyText = int.TryParse(IdKeyText, out int IdKey);

            Console.WriteLine($"The name of the employee is {EmployeeNames[IdKey]} ");
            Console.ReadLine();
        }
    }
}
