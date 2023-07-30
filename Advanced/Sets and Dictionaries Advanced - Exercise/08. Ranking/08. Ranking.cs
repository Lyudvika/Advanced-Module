using System.Drawing;

Dictionary<string, string> contestInfo = new Dictionary<string, string>();  //contestName & password
string command;

while  ((command = Console.ReadLine()) != "end of contests")
{
    string[] cmdArg = command.Split(":",StringSplitOptions.RemoveEmptyEntries);
    string contestName = cmdArg[0];
    string contestPassword = cmdArg[1];

    if (!contestInfo.ContainsKey(contestName))
    {
        contestInfo.Add(contestName, contestPassword);
    }
}

Dictionary<string, Dictionary<string, int>> userInfo = new Dictionary<string, Dictionary<string, int>>();   //username -> contestName & points
Dictionary<string, int> individualRanking = new Dictionary<string, int>();

while ((command = Console.ReadLine()) != "end of submissions")
{
    string[] cmdArg = command.Split("=>", StringSplitOptions.RemoveEmptyEntries);
    string contestName = cmdArg[0];
    string contestPassword = cmdArg[1];
    string username = cmdArg[2];
    int points = int.Parse(cmdArg[3]);

    if (!contestInfo.ContainsKey(contestName) || contestInfo[contestName] != contestPassword)
    {
        continue;
    }

    if (!userInfo.ContainsKey(username))
    {
        userInfo.Add(username, new Dictionary<string, int>());
        individualRanking.Add(username, 0);
    }
    if (!userInfo[username].ContainsKey(contestName))
    {
        userInfo[username].Add(contestName, points);
        individualRanking[username] += points;
    }
    else if (userInfo[username][contestName] < points)
    {
        individualRanking[username] -= userInfo[username][contestName];
        individualRanking[username] += points;
        userInfo[username][contestName] = points;
    }
}

var bestCandidat = individualRanking.OrderByDescending(p => p.Value).FirstOrDefault();
Console.WriteLine($"Best candidate is {bestCandidat.Key} with total {bestCandidat.Value} points.");
Console.WriteLine("Ranking:");

foreach (var user in userInfo.OrderBy(n => n.Key))
{
    Console.WriteLine(user.Key);
    foreach (var contest in user.Value.OrderByDescending(x => x.Value))
    {
        Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
    }
}