Queue<string> road = new Queue<string>();

int greenLightSeconds = int.Parse(Console.ReadLine());
int freeWindow =  int.Parse(Console.ReadLine());
string inputLine;

int totalCarsPassed = 0;

while ((inputLine = Console.ReadLine()) != "END")
{
    if (inputLine != "green")
    {
        road.Enqueue(inputLine);
        continue;
    }

    int secondsToPass = greenLightSeconds;
    int extraSeconds = freeWindow;
    while (road.Any())
    {
        string car = road.Dequeue();
        secondsToPass -= car.Length;
        if (secondsToPass <= 0)
        {
            extraSeconds += secondsToPass;
            if (extraSeconds < 0)
            {
                string crashSide = car.Substring(car.Length - Math.Abs(extraSeconds), 1);  //may have error here
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{car} was hit at {crashSide}.");
                return;
            }
            else
            {
                totalCarsPassed++;
                break;
            }
        }
        totalCarsPassed++;
    }
}

Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");