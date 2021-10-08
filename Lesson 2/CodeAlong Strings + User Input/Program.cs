using System;

namespace CodeAlong_Strings___User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            name = name.Trim();
            Console.WriteLine($"Hello {name}!");
        }
    }
}
