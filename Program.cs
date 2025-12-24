namespace SnakesAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int player;
            int currentP = 0;
            int diceCount = 0;

            
           Random r = new Random();
            while (currentP != 100)
            {

                int diceNumber = r.Next(1, 7);
                diceCount++;

                int option = r.Next(0, 3);
                int prevP = currentP;
                if (option == 0)
                {
                    Console.WriteLine("Option: No Play");
                }

                else if (option == 1)
                {
                    currentP += diceNumber;
                }
                else
                {
                    currentP -= diceNumber;
                }
                if (currentP < 0)
                {
                    currentP = 0;
                }
                if (currentP > 100)
                {
                    currentP = prevP;
                }
                Console.WriteLine("Player current position: " + currentP);
                Console.WriteLine("--------------------------------");

            }
                Console.WriteLine();

                Console.WriteLine("Player has won the game!");

        }
    }
}
