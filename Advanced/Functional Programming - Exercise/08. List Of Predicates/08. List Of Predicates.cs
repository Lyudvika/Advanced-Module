List<Predicate<int>> predicates = new List<Predicate<int>>();       //making a list of predicates, so we can go through all the numbers and check which one matches the description

int endRange = int.Parse(Console.ReadLine());
HashSet<int> dividers = Console.ReadLine()                          //making a hashset, because some of the numbers from the input may repeat
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToHashSet();

foreach (var divider in dividers)
{
    predicates.Add(n => n % divider == 0);                          //filling the list of predicates to match all the needed checks that need to be done
}

int[] numbers = Enumerable.Range(1, endRange).ToArray();            //making an array with all the nums from 1 to n (like filling an array with a for-loop i=1 -> i <=n)

foreach (var number in numbers)
{
    bool isDivisible = true;

    foreach (var match in predicates)
    {
        if (!match(number))
        {
            isDivisible = false;
            break;
        }
    }

    if (isDivisible)
    {
        Console.Write($"{number} ");
    }
}