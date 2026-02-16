namespace DiceRollGame
{
    class InputValidator
    {
        public static bool IsValid(int input)
        {
            if ( input > 0 && input <= 6)
            {
                return true;
            }
            else
                return false;
        }
    }
}