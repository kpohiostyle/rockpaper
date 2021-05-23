using System;
using rockpaper.Models;

namespace rockpaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // SECTION Number Game
            Console.Clear();
            Console.WriteLine("You Wanna play a game? (Y/N)");
            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            if (choice == 'y' || choice == 'Y')
            {
                Console.WriteLine("Lets Play!");
            }
            else if (choice == 'n' || choice == 'N')
            {
                Console.WriteLine("TOO BAD!");
            }
            else
            {
                Console.WriteLine("Your Stupidity is upsetting, lets play anyway");
            }
            bool running = true;
            while (running)
            {

                Console.Clear();
                Game game = new Game();
                bool playing = true;
                while (playing)
                {

                    Console.Write("What is your guess: ");
                    string guess = Console.ReadLine();
                    if (int.TryParse(guess, out int intGuess))
                    {
                        playing = !game.Guess(intGuess);
                    }
                    else
                    {
                        Console.WriteLine("Thats not even a number you bozo");
                    }
                }
                System.Console.WriteLine("GG BRO");
                System.Console.WriteLine("Play again?");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine("");
                if (choice == 'y')
                {
                    Console.WriteLine("Lets Play!");
                }
                else if (choice == 'n')
                {
                    Console.WriteLine("Bye Loser!");
                    running = false;
                }
                else
                {
                    Console.WriteLine("Your Stupidity is upsetting, I'm done");
                    running = false;
                }
            }
        }


