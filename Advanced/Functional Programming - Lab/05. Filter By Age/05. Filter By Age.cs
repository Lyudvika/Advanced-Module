Dictionary<string, int> people = ReadPeople();
Func<int, bool> filter = CreateFilter();
Action<KeyValuePair<string, int>> printer = CreatePrinter();
PrintFilteredPeople(people, filter, printer);

Dictionary<string, int> ReadPeople()
{
    int numOfPeople = int.Parse(Console.ReadLine());
    Dictionary<string, int> result = new Dictionary<string, int>();

    for (int i = 0; i < numOfPeople; i++)
    {
        string[] personInfo = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
        string personName = personInfo[0];
        int personAge = int.Parse(personInfo[1]);
        result.Add(personName, personAge);
    }

    return result;
}

Func<int, bool> CreateFilter()
{
    string condition = Console.ReadLine();
    int ageThreshold = int.Parse(Console.ReadLine());

    if (condition == "older")
    {
        filter = ageGroup => ageGroup >= ageThreshold;
    }
    else
    {
        filter = ageGroup => ageGroup < ageThreshold;
    }

    return filter;
}

Action<KeyValuePair<string, int>> CreatePrinter()
{
    string[] typeOfOutput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    Action<KeyValuePair<string, int>> result;

    if (typeOfOutput.Length == 2)
    {
        result = item => Console.WriteLine(item.Key + " - " + item.Value);
    }
    else if (typeOfOutput[0] == "name")
    {
        result = item => Console.WriteLine(item.Key);
    }
    else
    {
        result = item => Console.WriteLine(item.Value);
    }

    return result;
}

void PrintFilteredPeople(Dictionary<string, int>  people, Func<int, bool> filter, Action<KeyValuePair<string, int>>  printer)
{
    foreach (KeyValuePair<string, int> item in people.Where(person => filter(person.Value)))
    {
        printer(item);
    }
}