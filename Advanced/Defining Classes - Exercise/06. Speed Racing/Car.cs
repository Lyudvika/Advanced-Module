namespace DefiningClasses;
public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumptionPerKilometer;
    private double travelledDistance;

    public Car(string model, double fuel, double fuelConsumption, double travelled)
    {
        Model = model;
        fuelAmount = fuel;
        fuelConsumptionPerKilometer = fuelConsumption;
        travelledDistance = travelled;
    }

    public string Model { get { return model; } set { model = value; } }

    //methods
    public void Drive(double amountOfKm)
    {
        double fuelNeeded = fuelConsumptionPerKilometer * amountOfKm;
        if (fuelNeeded <= fuelAmount)
        {
            fuelAmount -= fuelNeeded;
            travelledDistance += amountOfKm;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }

    public override string ToString()
    {

        return $"{model} {fuelAmount:f2} {travelledDistance}";
    }
}