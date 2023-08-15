using Threeuple;

string[] personTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] drinkTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] numbersTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

CustomThreeuple<string, string, string> nameAddress = new($"{personTokens[0]} {personTokens[1]}", personTokens[2], string.Join(" ", personTokens[3..]));    //for the city read till end [3..]

CustomThreeuple<string, int, bool> nameBeer = new(drinkTokens[0], int.Parse(drinkTokens[1]), drinkTokens[2] == "drunk");

CustomThreeuple<string, double, string> bankTokens = new(numbersTokens[0], double.Parse(numbersTokens[1]), numbersTokens[2]);

Console.WriteLine(nameAddress);
Console.WriteLine(nameBeer);
Console.WriteLine(bankTokens);