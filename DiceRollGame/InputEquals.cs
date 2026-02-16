namespace DiceRollGame
{
    public class InputEquals
    {
        public static bool IsEqual(int input)
        {
            if (input.Equals(DiceRandom.RandomDice()))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}