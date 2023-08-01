int[] inputNums = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

string command = Console.ReadLine();

Predicate<int> isEvenNumber = number => number % 2 == 0;
Predicate<string> isEvenCommand = c => c == "even";

for (int i = inputNums[0]; i <= inputNums[1]; i++)
{
    if (isEvenNumber(i) && isEvenCommand(command))
    {
        Console.Write(i + " ");
    }
    else if(!isEvenNumber(i) && !isEvenCommand(command))
    {
        Console.Write(i + " ");
    }
}