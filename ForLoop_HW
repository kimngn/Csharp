/*Ask the user for a comma-seperated list of
 * first names(no spaces).
 * Split the string into a string array. 
 * Loop through the arry and tell each person 
 * hello
 * 
 * 
 * 
 */


using System;

namespace ForLoop_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
            Console.WriteLine("Give me the list of names with comma (no space bitch !)");
            data = Console.ReadLine();

            string[] firstNames = data.Split(',');
            for (int i = 0; i < firstNames.Length; i++)
            {
                Console.WriteLine($"Hello {firstNames[i]}");
            }

            
            Console.ReadLine();
        }
    }
}
