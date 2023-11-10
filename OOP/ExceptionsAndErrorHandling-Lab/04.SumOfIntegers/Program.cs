string[] input = Console.ReadLine().Split(" ");

int sum = 0;

foreach (string value in input)
{
    try
    {
        int num = int.Parse(value);

        sum += num;
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"The element '{value}' is in wrong format!");
    }
    catch (OverflowException ex)
    {
        Console.WriteLine($"The element '{value}' is out of range!");
    }
    finally
    {
        Console.WriteLine($"Element '{value}' processed - current sum: {sum}");
    }
}
Console.WriteLine($"The total sum of all integers is: {sum}");