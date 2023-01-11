using MyFirstProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            Console.WriteLine(message);
            var random = new Random();
            int score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(0, 10);
                secondNumber = random.Next(0, 10);
                Console.WriteLine($"{firstNumber} + {secondNumber} = ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Not correct this time, but I know you can do better!");
                }
                if (i == 4)
                {
                    Console.WriteLine($"Your score is {score}.");
                }
            }

            Helpers.AddToHistory(score, GameType.Addition);

        }
        internal void SubtractionGame(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine(message);
            var random = new Random();
            int score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(0, 10);
                secondNumber = random.Next(0, 10);
                Console.WriteLine($"{firstNumber} - {secondNumber} = ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Not correct this time, but I know you can do better!");
                }
                if (i == 4)
                {
                    Console.WriteLine($"Your score is {score}.");
                }
            }

            Helpers.AddToHistory(score, GameType.Subtraction);
        }
        internal void MultiplicationGame(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine(message);
            var random = new Random();
            int score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(0, 10);
                secondNumber = random.Next(0, 10);
                Console.WriteLine($"{firstNumber} x {secondNumber} = ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Not correct this time, but I know you can do better!");
                }
                if (i == 4)
                {
                    Console.WriteLine($"Your score is {score}.");
                }
            }

            Helpers.AddToHistory(score, GameType.Multiplication);
        }
        internal void DivisionGame(string message)
        {
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);


                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Not correct this time, but I know you can do better!");
                }
                if (i == 4)
                {
                    Console.WriteLine($"Your score is {score}.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.Division);
        }
    }
}
