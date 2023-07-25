HashSet<string> cars = new HashSet<string>();
string command;

while ((command = Console.ReadLine()) != "END")
{
    string[] cmdArg = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string cmdType = cmdArg[0];
    string carPlate = cmdArg[1];

    if (cmdType == "IN")
    {
        cars.Add(carPlate);
    }
    else if (cmdType == "OUT")
    {
        cars.Remove(carPlate);
    }
}

if (cars.Count > 0)
{
    Console.WriteLine(string.Join(System.Environment.NewLine, cars));
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}