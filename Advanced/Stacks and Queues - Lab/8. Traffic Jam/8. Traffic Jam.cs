Queue<string> cars = new Queue<string>();
int n = int.Parse(Console.ReadLine());
int carsPassed = 0;
string input;

while ((input = Console.ReadLine()) != "end")
{
    if (input == "green")
    {
        for (int i = 0; i < n; i++)
        {
            if (cars.Count <= 0)
            {
                break;
            }
            Console.WriteLine($"{cars.Dequeue()} passed!");
            carsPassed++;
        }
    }
    else
    {
        cars.Enqueue(input);
    }
}

Console.WriteLine($"{carsPassed} cars passed the crossroads.");