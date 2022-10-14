namespace Uppgift1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            void WheelSpin()
            {
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(1500);
                    Console.Write(" . ");
                }
                Console.WriteLine();
            }

            Random lyckyWheel = new Random();

            int wheelNum = lyckyWheel.Next(1, 11);

            int guess = 0;

            Console.WriteLine("Welcome to the lycky wheeeeeeeel!!!!!");

            while (wheelNum != guess)
            {
                Console.Write("Please guess a number: ");
                guess = int.Parse(Console.ReadLine());

                Console.Write($"Please wait while we spin the wheel");

                WheelSpin();

                if (wheelNum == guess)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\nYou guessed right!!! Congratulations!!!!!");
                }
                else
                {
                    Console.WriteLine("That wasn't the right number. You simply must try again.");
                }
            }

            Console.ReadKey();

        }
    }
}