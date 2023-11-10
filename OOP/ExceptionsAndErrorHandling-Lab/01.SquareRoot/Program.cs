int num = int.Parse(Console.ReadLine());
try
{

    if (num < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(num), "Invalid number.");
    }

    Console.WriteLine(Math.Sqrt(num));
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine("Invalid number.");
}
finally
{
    Console.WriteLine("Goodbye.");
}