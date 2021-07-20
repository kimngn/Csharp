using System;
using System.Linq;
// create a function to input a string and count number of spaces are in the string



namespace functionCountStringSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your string");
            string input = Console.ReadLine();
            int count = CountSpaceString(input);

            Console.WriteLine($"{input} string contains {count} spaces");


            Console.ReadLine();
        }

        private static int CountSpaceString(string input)
        {
          
            int count = input.Count(s => s == ' ');

            return count;
          

        }
    }
}
