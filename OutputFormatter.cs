/*Write an application that includes 2 additions methods
 * One method should return a string consisting of four or five lines
 * of information about your school.
 * 
 * Other method should return a string consisting of asterisks.
 * 
 * First call the method that returns the string of asterisks. Call the method that returns 
 * the asterisk a second time after you invoke the method that displays the information
 * about your school.
 * 
 * Items you migh include are:
 * Name of your school
 * Number of students enrolles, school colors. Include appropriate labels.
 * The display should be aesthetically pleasing so include enough
 * asterisk to surround your listing.
 * 
 * 
 * */

using System;

namespace OutputFormatter
{
    class Program
    {
        static void Main(string[] args)
        {
            string displaySchoolInfo = SchoolInfor();
            string asterisk = Display();

            Console.WriteLine(asterisk);
            Console.WriteLine(displaySchoolInfo);          
            Console.WriteLine(asterisk);

            Console.ReadLine();
        }

        private static string Display()
        {
            string a = "********************************************************";
            return a;
        }
        

        private static string SchoolInfor()
        {
            string schoolName ="Wichita State University";
            int studentNumber = 8;
            string schoolColor = "Yellow";
            string info = $"{ schoolName} \n {studentNumber} \n {schoolColor}";

            return info;

        }

    }
}
