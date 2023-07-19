string input = Console.ReadLine();
Stack<char> reversedLetters = new Stack<char>();
foreach (char ch in input)
{
    reversedLetters.Push(ch);
}

Console.WriteLine(string.Join("", reversedLetters));