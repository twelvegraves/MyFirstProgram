using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine($"Hello {name.ToUpper()}, It's {date}. What game would you like to play? \n -------------");
            bool gameIsOn = true;
            do
            {
                Console.WriteLine("\n Addition Game - a \n Subtraction Game - s\n Multiplication Game - m\n Division Game - d\n View Scores - v\n Quit - q \n---------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "a":
                        gameEngine.AdditionGame("You have selected Additon.");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("You have selected Subtraction.");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("You have selected Multiplication.");
                        break;
                    case "d":
                        gameEngine.DivisionGame("You have selected Division.");
                        break;
                    case "q":
                        Console.WriteLine("You are ending the game.");
                        gameIsOn = false;
                        break;
                    case "v":
                        Helpers.GetGames();
                        break;
                    default:
                        Console.WriteLine("Invalid statement.");
                        break;
                }
            } while (gameIsOn);
        }
    }
}
