using System;

namespace RoPaSci
{
    enum GameItem
    {
        Rock,
        Paper,
        Scissors
    }

    enum GameStatus
    {
        Draw,
        Player1Wins,
        Player2Wins
    }

    class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Please provide two valid game items (Rock, Paper, Scissors).");
                return;
            }

            try
            {
                GameItem player1 = Enum.Parse<GameItem>(args[0], true);
                GameItem player2 = Enum.Parse<GameItem>(args[1], true);

                GameStatus result = RockPaperScissors(player1, player2);

                switch (result)
                {
                    case GameStatus.Draw:
                        Console.WriteLine("It's a draw!");
                        break;
                    case GameStatus.Player1Wins:
                        Console.WriteLine("Player 1 wins!");
                        break;
                    case GameStatus.Player2Wins:
                        Console.WriteLine("Player 2 wins!");
                        break;
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid input. Use Rock, Paper, or Scissors.");
            }
        }

        private static GameStatus RockPaperScissors(GameItem player1, GameItem player2)
        {
            if (player1 == player2)
                return GameStatus.Draw;

            return (player1, player2) switch
            {
                (GameItem.Rock, GameItem.Scissors) => GameStatus.Player1Wins,
                (GameItem.Scissors, GameItem.Paper) => GameStatus.Player1Wins,
                (GameItem.Paper, GameItem.Rock) => GameStatus.Player1Wins,
                _ => GameStatus.Player2Wins
            };
        }
    }
}
