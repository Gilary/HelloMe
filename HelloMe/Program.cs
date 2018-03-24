using System;


namespace HelloMe
{
    class Program
    {
        static void Main()
        {
            string Name = "";

            Console.WriteLine("Please enter your name");
            Name = Console.ReadLine();
            Console.WriteLine("Hello " + Name);
            Console.ReadLine();
        }
    }
}
