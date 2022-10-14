namespace Uppgift2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool Ask(string answer) => answer.ToLower() == "no";

            void DiceRoll(int dice, int sidedice)
            {
                Random randomDice = new Random();

                for (int i = 1; i <= dice; i++)
                {
                    Console.Write($"Dice {i}# - {randomDice.Next(1,sidedice+1)}   ");
                }

                Console.WriteLine("\n");
            }
            
            int dice, sideDice;

            while (true)
            {

                Console.Write("How many dice do you want to throw?: ");
                dice = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("How many sides do you want the dice to have?: ");
                sideDice = int.Parse(Console.ReadLine());

                Console.WriteLine();

                DiceRoll(dice, sideDice);

                Console.Write("Do you wanna roll again? (Yes/No): ");

                if (Ask(Console.ReadLine()))
                {
                    break;
                }

                Console.WriteLine();

            }
        }
    }
}