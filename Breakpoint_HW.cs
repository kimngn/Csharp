/*app with a for loop that
 * multiplies a number by 
 * five and adds it to the total 
 * each time.Step through the code.
 * 
 * 
 * 
 * */


using System;

namespace Breakpoint_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            int total;
            for (int i = 0; i < 10; i++)
            {
                i = i * 5;   //i = 5, i = 30

                total =+ i;  // total = 5; total = 30
            }


            Console.ReadLine();
        }
    }
}
