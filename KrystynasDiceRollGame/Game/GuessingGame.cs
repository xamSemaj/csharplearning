using System;
using System.Collections.Generic;
using System.Text;
using KrystynasDiceRollGame.UserCommunication;
namespace KrystynasDiceRollGame.Game
{
    partial class GuessingGame
    {
        private readonly Dice _dice;
        // private readonly ConsoleReader _consoleReader;
        private const int InitialTries = 3;

        public GuessingGame(Dice dice)
        {
            _dice = dice;
            //_consoleReader = consoleReader;
        }

        public GameResult Play()
        {
            var diceRollResult = _dice.Roll();
            Console.WriteLine($"Dice Rolled. Guess what number it shows in {InitialTries} tries");
            var triesLeft = InitialTries;
            while (triesLeft > 0)
            {
                var guess = ConsoleReader.ReadInteger("Enter a number:");
                if (guess == diceRollResult)
                {
                    return GameResult.Victory;
                }
                Console.WriteLine("Wrong number.");
                --triesLeft;
            }
            return GameResult.Loss;
        }

        public static void PrintResult(GameResult gameResult)
        {

            string message = gameResult == GameResult.Victory
                ? message = "You Win!"
                : message = "NIGGERS";

            Console.WriteLine(message);


            //string message;
            //if (gameResult == GameResult.Victory)
            //{
            //    message = "You Win!";
            //}
            //else
            //{
            //   message = "NIGGERS";
            //}
            //Console.WriteLine(message);
        }



    }
}
