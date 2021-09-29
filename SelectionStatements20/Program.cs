using System;

namespace SelectionStatements20
{
    class Program
    {
        static void Main(string[] args)
        {
            int favNum = 80;
            Console.WriteLine("Try guessing my favorite number.....");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNum)
                Console.WriteLine("Too low!");
            else if (userInput > favNum)
                Console.Write("Too high!");
            else
                Console.WriteLine("Nevermind.");
            
        }
    }
}
