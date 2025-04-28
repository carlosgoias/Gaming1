using Gaming1.Model;

namespace Gaming1.Engine;

internal abstract class GameEngineBase : IGameEngine
{
    protected readonly List<Player> _players = [];

    public abstract void Start();

    protected abstract bool PlayTurn(Player player);

    protected void PrintLeaderboard(Player winner)
    {
        Console.WriteLine("\n--- Game Over ---");
        Console.WriteLine("Leaderboard:");

        foreach (var player in _players)
        {
            var winnerMark = player == winner ? " (Winner!)" : "";

            Console.WriteLine($"{player.Name}: {player.Attempts} attempts{winnerMark}");
        }
    }

    protected void SetupPlayers()
    {
        int numberOfPlayers = 0;

        while (numberOfPlayers < 1)
        {
            Console.Write("Enter number of players (at least 1): ");
            if (!int.TryParse(Console.ReadLine(), out numberOfPlayers) || numberOfPlayers < 1)
            {
                Console.WriteLine("Invalid input. Please enter a valid number greater than 0.");
                numberOfPlayers = 0;
            }
        }

        for (int i = 0; i < numberOfPlayers; i++)
        {
            var name = string.Empty;
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write($"Enter name for player {i + 1}: ");
                name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Invalid input. Name cannot be empty.");
                }
            }

            _players.Add(new Player(name));
        }
    }
}