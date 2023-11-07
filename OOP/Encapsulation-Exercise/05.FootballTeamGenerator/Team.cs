namespace FootballTeamGenerator;

public class Team
{
    private const string InvalidNameException = "A name should not be empty.";

    private string name;
    private List<Player> players;

    public Team(string name)
    {
        Name = name;
        players = new List<Player>();
    }

    public string Name
    {
        get => name;
        private set
        {
            if (string.IsNullOrEmpty(value))
                throw new AggregateException(InvalidNameException);

            name = value;
        }
    }

    public double Rating
    {
        get
        {
            if (players.Any())
                return players.Sum(p => p.Stats) / 5;

            return 0;
        }
    }

    public void AddPlayer(Player player) => players.Add(player);

    public void RemovePlayer(string playerName)
    {
        Player player = players.FirstOrDefault(n => n.Name  == playerName);

        if (player == null)
            throw new ArgumentException($"Player {playerName} is not in {Name} team.");

        players.Remove(player);
    }

    public override string ToString()
        => $"{Name} - {Rating:f0}";
}