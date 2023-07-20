int n = int.Parse(Console.ReadLine());

double priceSum = 0;

for (int i = 1; i <= n; i++)
{
    double pricePerCapsule = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsuleCount = int.Parse(Console.ReadLine());
    double price = days * capsuleCount * pricePerCapsule;
    priceSum += price;
    Console.WriteLine($"The price for the coffee is: ${price:f2}");
}
Console.WriteLine($"Total: ${priceSum:f2}");