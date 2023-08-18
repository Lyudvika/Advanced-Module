using DefiningClasses;
public class StartUp
{
    public const string Separator = " ";
    public const string EndCommand = "End";
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();

        int numOfCars = int.Parse(Console.ReadLine());
        for (int i = 0; i < numOfCars; i++)
        {
            string[] cmdArg = Console.ReadLine().Split(Separator, StringSplitOptions.RemoveEmptyEntries);
            string model = cmdArg[0];
            double fuelAmount = double.Parse(cmdArg[1]);
            double fuelConsumptionPerKilometer = double.Parse(cmdArg[2]);

            Car car = new Car(model, fuelAmount, fuelConsumptionPerKilometer, 0);
            cars.Add(car);
        }

        string command;
        while ((command = Console.ReadLine()) != EndCommand)
        {
            string[] cmdArg = command.Split(Separator, StringSplitOptions.RemoveEmptyEntries);
            string carModel = cmdArg[1];
            double amountOfKm = double.Parse(cmdArg[2]);

            foreach (var model in cars)
            {
                if (carModel == model.Model)
                {
                    model.Drive(amountOfKm);
                    break;
                }
            }
        }

        Console.WriteLine(string.Join(System.Environment.NewLine, cars));
    }
}