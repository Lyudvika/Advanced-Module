using FootballTeamGenerator;
using System.Windows.Input;

public class Program
{
    private const string Splitter = ";";
    private const string EndCommand = "END";
    static void Main(string[] args)
    {
        List<Team> teams = new();
        string command;
        while ((command = Console.ReadLine()) != EndCommand)
        {
            string[] playerInfo = command.Split(Splitter, StringSplitOptions.RemoveEmptyEntries);

            switch (playerInfo[0])
            {
                case "Team":
                    AddTeams(playerInfo[1], teams);
                    break;
                case "Add":
                    AddPlayer(playerInfo[1], playerInfo[2], int.Parse(playerInfo[3]), int.Parse(playerInfo[4]), int.Parse(playerInfo[5]), int.Parse(playerInfo[6]), int.Parse(playerInfo[7]), teams);
                    break;
                case "Remove":
                    RemovePlayer(playerInfo[1], playerInfo[2], teams);
                    break;
                case "Rating":
                    PrintRating(playerInfo[1], teams);
                    break;
            }
        }
    }

    private static void AddTeams(string name, List<Team> teams)
    {
        try
        {
            teams.Add(new Team(name));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    private static void AddPlayer(string teamName, string playerName, int endurance, int sprint, int dribble, int passing, int shooting, List<Team> teams)
    {
        try
        {
            if (teams.Any(t => t.Name == teamName) == false)
            {
                throw new ArgumentException($"Team {teamName} does not exist.");
            }

            Team team = teams.First(t => t.Name == teamName);
            Player player = new(playerName, endurance, sprint, dribble, passing, shooting);
            team.AddPlayer(player);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    private static void RemovePlayer(string teamName, string playerName, List<Team> teams)
    {
        try
        {
            if (teams.Any(t => t.Name == teamName) == false)
                Console.WriteLine($"Player {playerName} is not in {teamName} team.");

            Team team = teams.First(t => t.Name == teamName);
            team.RemovePlayer(playerName);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    private static void PrintRating(string teamName, List<Team> teams)
    {
        try
        {
            if (teams.Any(t => t.Name == teamName) == false)
            {
                throw new ArgumentException($"Team {teamName} does not exist.");
            }
            Team team = teams.First(t => t.Name == teamName);
            Console.WriteLine(team);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}