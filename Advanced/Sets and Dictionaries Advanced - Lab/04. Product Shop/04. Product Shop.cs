Dictionary<string, Dictionary<string, double>> shopInfo = new Dictionary<string, Dictionary<string, double>>(); //shopName -> productName, price
string command;

while ((command = Console.ReadLine()) != "Revision")
{
    string[] cmdArg = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string shopName = cmdArg[0];
    string productName = cmdArg[1];
    double price = double.Parse(cmdArg[2]);

    if (!shopInfo.ContainsKey(shopName))
    {
        shopInfo.Add(shopName, new Dictionary<string, double>());
    }
    if (!shopInfo[shopName].ContainsKey(productName))
    {
        shopInfo[shopName].Add(productName, price);
    }
}

foreach (var shop in shopInfo.OrderBy(x => x.Key))
{
    Console.WriteLine($"{shop.Key}->");
    foreach (var product in shop.Value)
    {
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }
}