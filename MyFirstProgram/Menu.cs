using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    internal class Menu
    {   //goes from the original Program file to here, sets up GameEngine access, For The Game Engine
        GameEngine gameEngine = new();
        //starts the actual menu with access to games, passed name and date from original file
        internal void ShowMenu(string name, DateTime date)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine($"Hello {name.ToUpper()}, It's {date}. What game would you like to play? \n -------------");
            //bool sets up trigger to end game
            bool gameIsOn = true;
            do
            {
                Console.WriteLine("\n Addition Game - a \n Subtraction Game - s\n Multiplication Game - m\n Division Game - d\n View Scores - v\n Quit - q \n---------------");

                var gameSelected = Console.ReadLine();
                // each selection redirects to the gameEngine file, where the actual math is handled
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
                        //this q option turns the bool to false, ending the loop
                    case "q":
                        Console.WriteLine("You are ending the game.");
                        gameIsOn = false;
                        break;
                    case "v":
                        Helpers.GetGames();
                        break
                    default:
                        Console.WriteLine("Invalid statement.");
                        break;
                }
            } while (gameIsOn);
        }
    }
}
