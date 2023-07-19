using System.Text;

Stack<string> memory = new Stack<string>();

int numOfOperations = int.Parse(Console.ReadLine());
StringBuilder text = new StringBuilder();

for (int i = 0; i < numOfOperations; i++)
{
    string[] cmdArg = Console.ReadLine().Split().ToArray();
    string cmdType = cmdArg[0];
    if (cmdType == "1") //adding text
    {
        string textToAdd = cmdArg[1];
        text.Append(textToAdd);
        memory.Push(text.ToString());
    }
    else if (cmdType == "2")    //removing last n letters from the text
    {
        int countToErase = int.Parse(cmdArg[1]);        
        text.Remove(text.Length - countToErase, countToErase); 
        memory.Push(text.ToString());
    }
    else if (cmdType == "3") //writing on the console a letter at the given index from the text
    {
        int position = int.Parse(cmdArg[1]) - 1;

        if (position >= 0 && position < text.Length)
        {
            Console.WriteLine(text[position]);
        }
    }
    else if (cmdType == "4")    //undo (giving the previous state of the text)
    {
        memory.Pop();
        if (memory.Count > 0)
        {
            string previousVersion = memory.Peek();

            text = new StringBuilder(previousVersion);
        }
        else
        {
            text = new StringBuilder();
        }
    }
}