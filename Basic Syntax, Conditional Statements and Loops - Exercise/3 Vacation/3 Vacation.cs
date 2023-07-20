int numberOfPeople = int.Parse(Console.ReadLine());
string typeOfGroup = Console.ReadLine();        //Students, Business or Regular
string day = Console.ReadLine();        //Friday, Saturday or Sunday

double price = 0;
double discount = 0;

if (typeOfGroup == "Students")
{
    if (day == "Friday")
    {
        price = 8.45;
    }
    else if (day == "Saturday")
    {
        price = 9.80;
    }
    else
    {
        price = 10.46;
    }
    if (numberOfPeople >= 30)
    {
        discount = 0.15;
    }
}
else if (typeOfGroup == "Business")
{
    if (day == "Friday")
    {
        price = 10.90;
    }
    else if (day == "Saturday")
    {
        price = 15.60;
    }
    else
    {
        price = 16;
    }
    if (numberOfPeople >= 100)
    {
        numberOfPeople -= 10;
    }
}
else
{
    if (day == "Friday")
    {
        price = 15;
    }
    else if (day == "Saturday")
    {
        price = 20;
    }
    else
    {
        price = 22.50;
    }
    if (numberOfPeople >= 10 && numberOfPeople <= 20)
    {
        discount = 0.05;
    }
}

Console.WriteLine($"Total price: {(price - price * discount) * numberOfPeople:f2}");