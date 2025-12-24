using System;

namespace SnakesAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] position = { 0, 0 };
            int currentPlayer = 0;
            Random random = new Random();

           
            
                while (position[currentPlayer]!=100)
                {
                    int die = random.Next(1, 7);
                    int option = random.Next(0, 3); 

                    Console.WriteLine("\nPlayer " + (currentPlayer + 1));
                    Console.WriteLine("Die: " + die);

                    if (option == 1) // Ladder
                    {
                        
                            position[currentPlayer] += die;

                        Console.WriteLine("Ladder! Position: " + position[currentPlayer]);
                        
                    }
                    else if (option == 2) // Snake
                    {
                        position[currentPlayer] -= die;
                        if (position[currentPlayer] < 0)
                            position[currentPlayer] = 0;

                        Console.WriteLine("Snake! Position: " + position[currentPlayer]);
                        currentPlayer = 1 - currentPlayer; // Switch player
                    }
                    else // No Play
                    {
                        Console.WriteLine("No Play! Position: " + position[currentPlayer]);
                        currentPlayer = 1 - currentPlayer; // Switch player
                    }

                    if (position[currentPlayer] == 100)
                    {
                        Console.WriteLine("\n Player " + (currentPlayer + 1) + " WON THE GAME!");
                        break;
                    }
                }
        }

    }
 }

