
using KrystynasDiceRollGame.Game;

var random = new Random();
var dice = new Dice(random);
var guessingGame = new GuessingGame(dice);

GameResult gameresult = guessingGame.Play();
GuessingGame.PrintResult(gameresult);

    Console.ReadKey();

//Season firstSeason = Season.Spring;
//Season lastSeason = Season.Winter;
//int firstSeasonAsNumber = (int)firstSeason;
//int lastSeasonAsNumber = (int)lastSeason;
//Console.WriteLine(firstSeason);
//Console.WriteLine("As a number: " + firstSeasonAsNumber);
//Console.WriteLine(lastSeason);
//Console.WriteLine("As a number: " + lastSeasonAsNumber);
//Console.ReadKey();

//public enum Season
//{
//    Spring = 1,
//    Summer,
//    Autumn,
//    Winter
//}

