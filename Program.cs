namespace SnakesAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int player;
            int startP = 0;
            
           Random r = new Random();
            int diceNumber = r.Next(1 , 7);

            int options = r.Next(0, 3);
            if(options == 2)
            {
                startP+= diceNumber;
            }
            else if(options == 3)
            {
                startP-= diceNumber; 
            }
            
        }
    }
}
