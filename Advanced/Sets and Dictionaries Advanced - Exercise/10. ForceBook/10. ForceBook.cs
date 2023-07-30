internal class Program
{
    private const string DelimeterUserSide = " -> ";
    private const string DelimeterSideUser = " | ";
    private const string EndCommand = "Lumpawaroo";
    private static void Main(string[] args)
    {
        Dictionary <string, string> usersInfo = ReadInputInformation();
        ConsolePrint(usersInfo);
    }

    private static Dictionary<string, string> ReadInputInformation()
    {
        Dictionary<string, string> usersInfo = new Dictionary<string, string>();
        string command;

        while ((command = Console.ReadLine()) != EndCommand)
        {
            string[] cmdArg = command.Split(DelimeterUserSide, StringSplitOptions.RemoveEmptyEntries);

            if (cmdArg.Length == 1)
            {
                ImportUsers(usersInfo, cmdArg, command);
            }
            else
            {
                ChangeUsersSide(usersInfo, cmdArg);
            }
        }

        return usersInfo;
    }

    private static Dictionary<string, string> ImportUsers(Dictionary<string,string> usersInfo, string[] cmdArg, string command)
    {
        cmdArg = command.Split(DelimeterSideUser, StringSplitOptions.RemoveEmptyEntries);
        string forceSide = cmdArg[0];
        string forceUser = cmdArg[1];

        if (!usersInfo.ContainsKey(forceUser))  //if the user doesnt exist in the userInfo
        {
            usersInfo.Add(forceUser, forceSide);
        }

        return usersInfo;
    }

    private static Dictionary<string, string> ChangeUsersSide(Dictionary<string, string> usersInfo, string[] cmdArg)
    {
        string forceUser = cmdArg[0];
        string forceSide = cmdArg[1];

        if (usersInfo.ContainsKey(forceUser))   //if the user already exists
        {
            usersInfo[forceUser] = forceSide;   //the user joines a new force side 
        }
        else
        {
            usersInfo.Add(forceUser, forceSide);    //a new member joines a force side
        }

        Console.WriteLine($"{forceUser} joins the {forceSide} side!");

        return usersInfo;
    }

    private static void ConsolePrint(Dictionary<string, string> usersInfo)
    {
        foreach (var kvp in usersInfo.GroupBy(x => x.Value).OrderByDescending(x => x.Count()).ThenBy(x => x.Key))
        {
            Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Count()}");

            foreach (var users in kvp.OrderBy(x => x.Key))
            {
                Console.WriteLine($"! {users.Key} ");
            }
        }
    }
}