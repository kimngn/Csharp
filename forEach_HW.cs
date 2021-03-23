/*ask the user for their first name
 * continue to asking for first name until
 * there are no more.
 * then loop through each name
 * using foreach and tell them hello
 * */
using System;
using System.Collections.Generic;

namespace forEach_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstNames = new List<string>();
            string firstName = "";
            string answer = "";
            do
            {
                Console.WriteLine("What is your first name");
                firstName = Console.ReadLine();
                firstNames.Add(firstName);

                Console.WriteLine("do you want to add more ? y/n");
                answer = Console.ReadLine();
            }
            while (answer == "y");

            foreach (var item in firstNames)
            {
                Console.WriteLine($"Hello {item}");
            }

            Console.ReadLine();

        }
    }
}
