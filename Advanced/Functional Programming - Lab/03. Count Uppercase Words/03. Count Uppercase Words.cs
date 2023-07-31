List<string> inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

Func<string, bool> wordCriteria = (word) => char.IsUpper(word[0]);

inputLine.ForEach(word =>
    {
        if (wordCriteria(word))
        {
            Console.WriteLine(word);
        }
    });