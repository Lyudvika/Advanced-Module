var vLogger = new Dictionary<string, List<string>>();
var vloggerInfo = new Dictionary<string, List<int>>();

string command;

while ((command = Console.ReadLine()) != "Statistics")
{
    string[] cmdArg = command.Split();
    string vloggerName = cmdArg[0];
    string cmdType = cmdArg[1];
    string secVloggerName = cmdArg[2];

    if (cmdType == "joined")
    {
        if (!vLogger.ContainsKey(vloggerName))
        {
            vLogger.Add(vloggerName, new List<string>());
            vloggerInfo.Add(vloggerName, new List<int>());
            vloggerInfo[vloggerName].Add(0);
            vloggerInfo[vloggerName].Add(0);
        }
    }
    else if (cmdType == "followed")
    {
        if (vloggerName == secVloggerName)
        {
            continue;
        }
        if (!vLogger.ContainsKey(vloggerName) || !vLogger.ContainsKey(secVloggerName))
        {
            continue;
        }


        if (!vLogger[secVloggerName].Contains(vloggerName))
        {
            vLogger[secVloggerName].Add(vloggerName);
            vloggerInfo[vloggerName][0] += 1;
            vloggerInfo[secVloggerName][1] += 1;
        }
    }
}

int count = 1;
Console.WriteLine($"The V-Logger has a total of {vLogger.Count()} vloggers in its logs.");

foreach (var item in vloggerInfo.OrderBy(x => x.Value[0]).OrderByDescending(x => x.Value[1]))
{
    List<int> follower = item.Value;
    var itemToPrint = item.Value;

    Console.WriteLine($"{count++}. {item.Key} : {follower[1]} followers, {follower[0]} following");

    if (count == 2)
    {
        foreach (var vlogger in vLogger)
        {
            if (vlogger.Key == item.Key)
            {
                List<string> keyValuePairs = vlogger.Value.OrderBy(x => x).ToList();

                for (int i = 0; i < keyValuePairs.Count; i++)
                {
                    Console.WriteLine($"*  {keyValuePairs[i]}");
                }
                break;
            }
        }
    }
}