/*Create an array of 3 names
 * ask user which number to select
 * when the user gives you a number, return that name
 * */
using System;

namespace Array_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstNames = new string[3];
           // int index = 0;

            firstNames[0] = "Kim";
            firstNames[1] = "Quan";
            firstNames[2] = "Chi";
            
           Console.WriteLine("What number you select ?");
            string indexText = Console.ReadLine();

            bool isIndexinterger = int.TryParse(indexText, out int index);

            Console.WriteLine($"Your name is {firstNames[index -1]} ");

            Console.ReadLine();
        }
    }
}
