int lostGames = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());

int keyboard = 0;
double price = 0;

for (int i = 1; i <= lostGames; i++)
{
    if (i % 2 == 0)
    {
        price += headsetPrice;
    }
    if (i % 3 == 0)
    {
        price += mousePrice;
    }
    if (i % 3 == 0 && i % 2 == 0)
    {
        price += keyboardPrice;
        keyboard++;
        if (keyboard % 2 == 0)
        {
            price += displayPrice;
        }
    }
}
Console.WriteLine($"Rage expenses: {price:f2} lv.");