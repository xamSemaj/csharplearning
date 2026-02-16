namespace DiceRollGame
{
    class DiceRandom
    {
        public static int RandomDice()
        {
            Random rnd = new Random();

            return rnd.Next(1, 6);

        }

    }
}