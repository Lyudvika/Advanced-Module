HashSet<string> parking = new HashSet<string>();
string command;

while ((command = Console.ReadLine()) != "PARTY")
{
    parking.Add(command);
}

while ((command = Console.ReadLine()) != "END")
{
    parking.Remove(command);
}

Console.WriteLine(parking.Count);
Console.WriteLine(string.Join(System.Environment.NewLine, parking.OrderBy(x => !char.IsDigit(x[0]))));