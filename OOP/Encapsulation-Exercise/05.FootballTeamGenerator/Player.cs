namespace FootballTeamGenerator;

public class Player
{
    private const string StatExceptionMessage = "{0} should be between 0 and 100.";
    private const string InvalidNameMessage = "A name should not be empty.";
    private const int StatMinValue = 0;
    private const int StatMaxValue = 100;

    private string name;
    private int endurance;
    private int sprint;
    private int dribble;
    private int passing;
    private int shooting;

    public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
    {
        Name = name;
        Endurance = endurance;
        Sprint = sprint;
        Dribble = dribble;
        Passing = passing;
        Shooting = shooting;
    }

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException(InvalidNameMessage);

            name = value;
        }
    }

    public int Endurance
    {
        get => endurance;
        private set
        {
            if (value < StatMinValue || value > StatMaxValue)
                throw new ArgumentException(string.Format(StatExceptionMessage, nameof(Endurance)));

            endurance = value;
        }
    }
    public int Sprint
    {
        get => sprint;
        private set
        {
            if (value < StatMinValue || value > StatMaxValue)
                throw new ArgumentException(string.Format(StatExceptionMessage, nameof(Sprint)));

            sprint = value;
        }
    }
    public int Dribble
    {
        get => dribble;
        private set
        {
            if (value < StatMinValue || value > StatMaxValue)
                throw new ArgumentException(string.Format(StatExceptionMessage, nameof(Dribble)));

            dribble = value;
        }
    }
    public int Passing
    {
        get => passing;
        private set
        {
            if (value < StatMinValue || value > StatMaxValue)
                throw new ArgumentException(string.Format(StatExceptionMessage, nameof(Passing)));

            passing = value;
        }
    }
    public int Shooting
    {
        get => shooting;
        private set
        {
            if (value < StatMinValue || value > StatMaxValue)
                throw new ArgumentException(string.Format(StatExceptionMessage, nameof(Shooting)));

            shooting = value;
        }
    }

    public double Stats
    {
        get
        {
            return endurance + sprint + dribble + passing + shooting;
        }
    }

    public void AddPlayer(string teamName, string name, int endurance, int sprint, int dribble, int passing, int shooting, List<Team> teams)
    {
        Team team = teams.FirstOrDefault(t => t.Name == teamName);

        if (team == null)
        {
            Console.WriteLine($"Team {teamName} does not exist.");

            return;
        }

        try
        {
            Player player = new Player(name, endurance, sprint, dribble, passing, shooting);
            team.AddPlayer(player);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    
}