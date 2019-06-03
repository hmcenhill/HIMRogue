using System;

namespace HIMRogue
{
    class Program
    {
        static void Main(string[] args)
        {
            var newGame = new Game();
            newGame.Launch();

            Console.WriteLine("\n\n----------------------------------------");
            Console.WriteLine("Exiting HIMRogue. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
