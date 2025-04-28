using Gaming1.Model;

namespace Gaming1.Engine;

internal sealed class HiLoGameEngine(int min, int max) : GameEngineBase
{   
    private static readonly Random _random = new();
    private readonly int _mysteryNumber = _random.Next(min, max + 1);
        
    public int GetMysteryNumber() => _mysteryNumber;
     
    public override void Start()
    {
        Console.WriteLine("Welcome to the Multiplayer Hi-Lo Game!");
        Console.WriteLine($"Guess the mystery number between {min} and {max}.");

        SetupPlayers();

        bool gameWon = false;
        while (!gameWon)
        {
            foreach (var player in _players)
            {
                gameWon = PlayTurn(player);
                if (gameWon)
                {
                    Console.WriteLine($"The winner is player {player.Name}, guessed the mystery number {_mysteryNumber}!");
                    PrintLeaderboard(player);
                    break;
                }
            }
        }
    }

    protected override bool PlayTurn(Player player)
    {
        Console.WriteLine($"\nPlayer {player.Name}'s turn. ({min}-{max})");
        Console.Write("Enter your guess: ");

        if (!int.TryParse(Console.ReadLine(), out int playerGuess) || playerGuess < min || playerGuess > max)
        {
            Console.WriteLine("Invalid input. Turn skipped.");
            return false;
        }

        player.Attempts++;

        if (playerGuess < _mysteryNumber)
        {
            Console.WriteLine("HI! The mystery number is higher.");            
        }
        else if (playerGuess > _mysteryNumber)
        {
            Console.WriteLine("LO! The mystery number is lower.");            
        }
        else
        {           
            return true;
        }

        return false;
    }
}
