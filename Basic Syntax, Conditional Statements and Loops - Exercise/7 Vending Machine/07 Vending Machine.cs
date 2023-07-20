string input;
double moneyGiven;
double money = 0;
string food = "";

while ((input = Console.ReadLine()) != "End")
{
    while (input == "Start")
    {
        food = Console.ReadLine();
        if (food == "Nuts")
        {
            if (money >= 2.0)
            {
                money -= 2;
                Console.WriteLine("Purchased nuts");
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
        }
        else if (food == "Water")
        {
            if (money >= 0.7)
            {
                money -= 0.7;
                Console.WriteLine("Purchased water");
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
        }
        else if (food == "Crisps")
        {
            if (money >= 1.5)
            {
                money -= 1.5;
                Console.WriteLine("Purchased crisps");
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
        }
        else if (food == "Soda")
        {
            if (money >= 0.8)
            {
                money -= 0.8;
                Console.WriteLine("Purchased soda");
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
        }
        else if (food == "Coke")
        {
            if (money >= 1)
            {
                money -= 1;
                Console.WriteLine("Purchased coke");
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
        }
        else if (food == "End")
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid product");
        }
    }

    if (food == "End")
    {
        break;
    }
    moneyGiven = double.Parse(input);

    if (moneyGiven == 0.1 || moneyGiven == 0.2 || moneyGiven == 0.5 || moneyGiven == 1 || moneyGiven == 2)
    {
        money += moneyGiven;
    }
    else
    {
        Console.WriteLine($"Cannot accept {moneyGiven}");
    }
}

Console.WriteLine($"Change: {money:f2}");