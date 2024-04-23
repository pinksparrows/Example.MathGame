using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Menu
    {
        void Menu(string name)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"Hello {name}. It's {date.DayOfWeek}. This is your math's game. That's great that you're working on improving yourself!");
            Console.WriteLine("\n");

            var isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@"What game would you like to play today? Please choose from the options below:
V - View Previous Games
A - Add
S - Sub
M - Mult
D - Div
Q - Quit the Prog");
                Console.WriteLine("----------------------------------------------------------");
                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        GetGames();
                        break;
                    case "a":
                        AdditionGame("Addition game");
                        break;
                    case "s":
                        SubtractionGame("Subtraction game");
                        break;
                    case "m":
                        MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        DivisionGame("Division game");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            } while (isGameOn);


        }
    }
}
