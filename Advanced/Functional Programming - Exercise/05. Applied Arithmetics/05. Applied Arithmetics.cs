List<int> inputLine = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

string command;
string endCommand = "end";
Predicate<string> isAdd = command => command == "add";
Predicate<string> isMultiply = command => command == "multiply";
Predicate<string> isSubstract = command => command == "subtract";
Predicate<string> isPrint = command => command == "print";

while ((command = Console.ReadLine()) != endCommand)
{
    Func<int, int> funk = null;
    if (isAdd(command))
    {
        funk = num => ++num;
    }
    else if (isMultiply(command))
    {
        funk = num => num*2;
    }
    else if (isSubstract(command))
    {
        funk = num => --num;
    }
    else if (isPrint(command))
    {
        Console.WriteLine(string.Join(" ", inputLine));
        continue;
    }

    for (int i = 0; i < inputLine.Count; i++)
    {
        inputLine[i] = funk(inputLine[i]);
    }
}