using System;

namespace EZDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(Prints.Blank());

                Console.WriteLine(Prints.WelcomeMessage());
                Console.WriteLine(Prints.WelcomeMessageHelp());

                Console.WriteLine(Prints.Blank());

                Console.Write(Prints.Arrow());

                string userInput = Console.ReadLine();
                UserCommands.ReturnUserCommandInformation(userInput);
            }
        }
    }
}
