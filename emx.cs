using System;
//using EMX.Interpreter;

namespace EMX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EMX, a program created to replicate the functionality of a basic computer operating system.");
            Console.WriteLine("You are currently running EMX Start, the entry to the EMX Operating System.");
            Console.WriteLine("What you are reading right now was programmed in direct raw C#, but when you enter into EMX, it uses EMXScript, built using C#.");
            Console.WriteLine("Type 'help' for a list of commands.");

            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("No command entered. Type 'help' for a list of commands.");
                    continue;
                }

                switch (input.ToLower())
                {
                    case "help":
                        ShowHelp();
                        break;
                    case "exit":
                        Exit();
                        return;
                    default:
                        Console.WriteLine("Unknown command. Type 'help' for a list of commands.");
                        break;
                }
            }
        }

        static void ShowHelp()
        {
            Console.WriteLine("List of commands:");
            Console.WriteLine("help - Show this help message");
            Console.WriteLine("exit - Exit the program");
        }

        static void Exit()
        {
            Console.WriteLine("Exiting EMX Start...");
            Environment.Exit(0);
        }
    }
}