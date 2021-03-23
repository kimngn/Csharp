//Create a console app that ask user name, if username is Tim, print "hello professor", else "Hi _". Keep doing that until user said exit


using System;

namespace Homework_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName = "";

            while (firstName.ToLower() != "exit")
            {
                Console.Write("What is your name ?");
                firstName = Console.ReadLine();
                if (firstName.ToLower() == "tim")
                {
                    Console.WriteLine("Hello Professor");
                }
                else if (firstName.ToLower() != "exit")
                {
                    Console.WriteLine($"Hi {firstName}");
                }

            }
      
            Console.ReadLine();
        }
    }
}
