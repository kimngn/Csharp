using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = GetUserName();
            WelcomeUser(name);
            SayHello(name);
            Console.ReadLine();
        }

        private static void WelcomeUser(string firstName)
        {
            Console.WriteLine($"Welcome {firstName} ");
        }
        private static string GetUserName()
        {
            Console.WriteLine("what your name bitch ?");
            string output =  Console.ReadLine();
            return output;
        }

        private static void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
