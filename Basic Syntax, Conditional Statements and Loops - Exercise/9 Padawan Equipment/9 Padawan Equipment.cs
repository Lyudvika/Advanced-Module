double budget = double.Parse(Console.ReadLine());
int numberOfStudents = int.Parse(Console.ReadLine());
double lightsaberPrice = double.Parse(Console.ReadLine());
double robesPrice = double.Parse(Console.ReadLine());
double beltsPrice = double.Parse(Console.ReadLine());

double lightsabers = Math.Ceiling(numberOfStudents + (numberOfStudents * 0.1));
double belts = numberOfStudents;

for (int i = 6; i <= numberOfStudents; i+=6)
{
    belts--;
}

double price = lightsabers * lightsaberPrice + robesPrice * numberOfStudents + beltsPrice * belts;

if (price <= budget)
{
    Console.WriteLine($"The money is enough - it would cost {price:f2}lv.");
}
else
{
    Console.WriteLine($"John will need {price - budget:f2}lv more.");
}