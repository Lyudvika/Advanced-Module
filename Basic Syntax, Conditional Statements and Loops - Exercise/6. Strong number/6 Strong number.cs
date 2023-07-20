int n = int.Parse(Console.ReadLine());
int sum = 0;
int input = n;

while (n > 0)
{
    int number = n % 10;
    int currentSum = 1;
    for (int i = number; i >= 1; i--)
    {
        currentSum *= i;
    }
    sum += currentSum;
    n /= 10;
}

if (sum == input)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}