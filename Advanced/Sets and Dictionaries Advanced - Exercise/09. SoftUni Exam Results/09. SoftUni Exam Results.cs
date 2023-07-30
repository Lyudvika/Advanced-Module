Dictionary<string, int> userInfo = new Dictionary<string, int>();    //username & points
Dictionary<string, int> contestInfo = new Dictionary<string, int>();  //Language & int
string command;

while ((command = Console.ReadLine()) != "exam finished")
{
    bool chaangeMade = false;
    string[] cmdArg = command.Split("-", StringSplitOptions.RemoveEmptyEntries);
    string username = cmdArg[0];
    string languageOrBan = cmdArg[1];

    if (languageOrBan == "banned")
    {
        userInfo.Remove(username);
        continue;
    }

    int points = int.Parse(cmdArg[2]);

    if (!userInfo.ContainsKey(username))
    {
        userInfo.Add(username, 0);
    }
    userInfo[username] = Math.Max(userInfo[username], points);

    if (!contestInfo.ContainsKey(languageOrBan))
    {
        contestInfo.Add(languageOrBan, 0);
    }
    contestInfo[languageOrBan]++;
}

Console.WriteLine("Results:");

foreach (var user in userInfo.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{user.Key} | {user.Value}");
}

Console.WriteLine("Submissions:");

foreach (var contest in contestInfo.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{contest.Key} - {contest.Value}");
}