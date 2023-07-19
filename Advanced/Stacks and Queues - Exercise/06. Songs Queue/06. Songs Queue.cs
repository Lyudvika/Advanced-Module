string[] input = Console.ReadLine().Split(", ").ToArray();
Queue<string> songQueue = new Queue<string>(input);

while (songQueue.Count > 0)
{
    string[] cmdArgs = Console.ReadLine().Split().ToArray();
    string cmdType = cmdArgs[0];
    if (cmdType == "Play")
    {
        songQueue.Dequeue();
    }
    else if (cmdType == "Add")
    {
        string song = string.Join(" ",cmdArgs.Skip(1));
        if (!songQueue.Contains(song))
        {
            songQueue.Enqueue(song);
        }
        else
        {
            Console.WriteLine($"{song} is already contained!");
        }
    }
    else if (cmdType == "Show")
    {
        Console.WriteLine(string.Join(", ", songQueue));
    }
}

Console.WriteLine("No more songs!");