namespace DiceRollGame
{


    class DiceRollGame()
    {
        public static void Main()
        {
             for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Dice rolled. Guess What number it shows in 3 tries.");
                Console.WriteLine("Enter a number: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (InputEquals.IsEqual(input))
                {
                    Console.WriteLine("You Win!");
                    break;
                }
                else if (!InputValidator.IsValid(input))
                {
                    Console.WriteLine("Wrong number");
                }
                else
                {
                    Console.WriteLine("You Lose!");
                }
                
                if (i == 3)
                {
                    Console.WriteLine("You Lose!");
                    break;
                }
            }
          




        }



    }
}