List<Predicate<string>> predicates = new();                             //list of predicates
Dictionary<string, Predicate<string>> listOfPredicates = new();         //saving the predicates commands in the dictionary to access later on 

List<string> listOfPoeple = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string command;
string endCommand = "Print";
while ((command = Console.ReadLine()) != endCommand)
{
    string[] cmdArg = command.Split(";");
    string cmdType = cmdArg[0];
    string filter = cmdArg[1];
    string value = cmdArg[2];

    if (cmdType == "Add filter")
    {
        listOfPredicates.Add(filter + value, GetPredicate(filter, value));      //adding predicare to the dictionary
    }
    else if (cmdType == "Remove filter")
    {
        listOfPredicates.Remove(filter + value);                                //removing predicate from the dictionary
    }
}

foreach (var predicate in listOfPredicates)
{
    listOfPoeple.RemoveAll(predicate.Value);                                    //accessing all the predicates from the dictionaries value
}

Console.WriteLine(string.Join(" ", listOfPoeple));

Predicate<string> GetPredicate(string filter, string value)
{
    switch (filter)
    {
        case "Starts with":
            return p => p.StartsWith(value);
        case "Ends with":
            return p => p.EndsWith(value);
        case "Length":
            return p => p.Length == int.Parse(value);
        case "Contains":
            return p => p.Contains(value);
        default:
            return default;
    }
}