List <Predicate<string>> predicates = new();            //creating a list of predicates

List<string> listOfPeople = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string command;
string endCommand = "Party!";
while ((command = Console.ReadLine()) != endCommand)
{
    string[] cmdArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string cmdType = cmdArg[0];
    string filter = cmdArg[1];
    string value = cmdArg[2];

    if (cmdType == "Remove")
    {
        listOfPeople.RemoveAll(CheckRequirements(filter, value));           //removing all of the people that fit the requirements
    }
    else if (cmdType == "Double")
    {
        List<string> peopleToDouble = listOfPeople.FindAll(CheckRequirements(filter, value));       //adding all the people that fit the requirments

        foreach (string person in peopleToDouble)
        {
            int index = listOfPeople.IndexOf(person);           //checking at what index is the person in the list of people

            listOfPeople.Insert(index, person);                 //inserting the same person at the index
        }
    }
}

if (listOfPeople.Any())
{
    Console.WriteLine($"{string.Join(", ", listOfPeople)} are going to the party!");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}

static Predicate<string> CheckRequirements( string filter, string value)
{
    switch (filter)
    {
        case "StartsWith":
            return p => p.StartsWith(value);                //getting all of the people which names start with the given value
        case "EndsWith":
            return p => p.EndsWith(value);                  // getting all of the people which names end with the given value
        case "Length":
            return p => p.Length == int.Parse(value);       //getting all of the people which names length is equal to the given value (number)
        default:
            return default;
    }
}