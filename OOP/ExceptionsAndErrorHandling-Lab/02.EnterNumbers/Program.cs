List<int> numbers = new();

while (numbers.Count != 10)
{
    try
    {
        int currNum = int.Parse(Console.ReadLine());

        if (currNum <= 1 || currNum >= 100)
        {
            int lastNum = numbers.LastOrDefault() == 0
              ? 1
              : numbers.LastOrDefault();
            throw new ArgumentOutOfRangeException("", $"Your number is not in range {lastNum} - 100!");
        }
        else if (numbers.Count == 0)
        {
            numbers.Add(currNum);
        }
        else if (numbers.LastOrDefault() < currNum)
        {
            numbers.Add(currNum);
        }
        else
        {
            throw new ArgumentOutOfRangeException("", $"Your number is not in range {numbers.LastOrDefault()} - 100!");
        }
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Invalid Number!");
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.WriteLine(string.Join(", ", numbers));