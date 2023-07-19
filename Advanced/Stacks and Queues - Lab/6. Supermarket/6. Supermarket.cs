Queue<string> customerQueue = new Queue<string>();
string input;

while ((input = Console.ReadLine()) != "End")
{
    if (input == "Paid")
    {
        while (customerQueue.Count != 0)
        {
            Console.WriteLine(customerQueue.Dequeue());
        }
        continue;
    }
    customerQueue.Enqueue(input);
}

Console.WriteLine($"{customerQueue.Count} people remaining.");