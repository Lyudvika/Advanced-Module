using DefiningClasses;

public class StartUp
{
    public const string Separator = " ";
    static void Main(string[] args)
    {
        List<Engine> engines = new List<Engine>();
        List<Car> cars = new List<Car>();

        int numOfEngines = int.Parse(Console.ReadLine());
        for (int i = 0; i < numOfEngines; i++)
        {
            string[] cmdArg = Console.ReadLine().Split(Separator, StringSplitOptions.RemoveEmptyEntries);
            string model = cmdArg[0];
            int power = int.Parse(cmdArg[1]);
            int displacement = default;
            string efficiency = "n/a";

            if (cmdArg.Length == 3)
            {
                if (int.TryParse(cmdArg[2], out int reslut))
                {
                    displacement = int.Parse(cmdArg[2]);
                }
                else
                {
                    efficiency = cmdArg[2];
                }
            }
            else if (cmdArg.Length == 4)
            {
                displacement = int.Parse(cmdArg[2]);
                efficiency = cmdArg[3];
            }

            Engine engine = new Engine(model, power, displacement, efficiency);
            engines.Add(engine);
        }

        int numOfCars = int.Parse(Console.ReadLine());
        for (int i = 0; i < numOfCars; i++)
        {
            string[] cmdArg = Console.ReadLine().Split(Separator, StringSplitOptions.RemoveEmptyEntries);
            string model = cmdArg[0];
            string engine = cmdArg[1];
            int weight = default;
            string color = "n/a";

            if (cmdArg.Length == 3)
            {
                if (int.TryParse(cmdArg[2], out int reslut))
                {
                    weight = int.Parse(cmdArg[2]);
                }
                else
                {
                    color = cmdArg[2];
                }
            }
            else if (cmdArg.Length == 4)
            {
                weight = int.Parse(cmdArg[2]);
                color = cmdArg[3];
            }

            Car car = new Car(model, engines.Where(e => e.Model == engine).First(), weight, color);
            cars.Add(car);
        }

        Console.WriteLine(string.Join("", cars));
    }
}