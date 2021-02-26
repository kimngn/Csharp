/*Add students to a class roster
 * until there are no more students. Then
 * print out the count of the students to the
 * console
 * */



using System;
using System.Collections.Generic;

namespace List_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            int count = 0;
            List<string> firstNames = new List<string>();
            string studentName;
            do
            {
                
                Console.WriteLine("Add the student's name ?");
                studentName = Console.ReadLine();
                firstNames.Add(studentName);

                Console.WriteLine("Are there any more student y/n ?");
                answer = Console.ReadLine();

                
                
                
                count = count + 1;
            }
            while (answer == "y");

            Console.WriteLine($"The total number of students are added to class is {count}");

            Console.WriteLine("The name of the students are:");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(firstNames[i]);
            }
            

            Console.ReadLine();

        }
    }
}
