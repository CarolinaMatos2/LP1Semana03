using System;

namespace RPS
{
    class Program
    {
        private static void Main(string[] args)
        {
            if(args.Length < 2)
            {   
                Console.WriteLine("Escolham pedra, papel ou tesoura.");
                return;
            }
            GameItem player1Choice = Enum.Parse(args[0]);
            GameItem player2Choice = Enum.Parse(args[1]);

            GameStatus result = RockPaperScissors(player1Choice, player2Choice)
            switch (result)
            {
                case 0:
                    Console.WriteLine("It's a draw!");
                    break;
                case 1:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case 2:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static int RockPaperScissors(string player1, string player2)
        {
            if (player1 == player2)
            {
                return GameStatus.Draw; // Draw
            }
            if (((player1 == GameItem.Rock) && (player2 == GameItem.Scissors)) ||
                ((player1 == GameItem.Scissors) && (player2 == GameItem.Paper)) ||
                ((player1 == GameItem.Paper) && (player2 == GameItem.Rock)))
            {
                return GameStatus.Player1Wins; // Player 1 wins
            }
            else
            {
                return GameStatus.Player2Wins; // Player 2 wins
            }
        }
    }
}
