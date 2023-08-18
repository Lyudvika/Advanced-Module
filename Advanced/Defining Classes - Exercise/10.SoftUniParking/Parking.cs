namespace SoftUniParking;
internal class Parking
{
    private Dictionary<string, Car> cars;
    private int capacity;

    public Parking(int capacity)
    {
        this.capacity = capacity;
        cars = new();
    }

    public string Make { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
    public string RegistrationNumber { get; set; }

    public int Count { get; set; }

    //methods
    public string AddCar(Car car)
    {
        if (cars.ContainsKey(car.RegistrationNumber))
        {
            return "Car with that registration number, already exists!";
        }
        else if (cars.Count >= capacity)
        {
            return "Parking is full!";
        }

        cars.Add(car.RegistrationNumber, car);
        Count++;

        return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
    }

    public string RemoveCar(string registrationNumber)
    {
        if (!cars.ContainsKey(registrationNumber))
        {
            return "Car with that registration number, doesn't exist!";
        }

        cars.Remove(registrationNumber);
        Count--;

        return $"Successfully removed {registrationNumber}";
    }

    public Car GetCar(string registrationNumber)
    {
        return cars[registrationNumber];
    }

    public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
    {
        foreach (string registrationNumber in registrationNumbers)
        {
            if (cars.ContainsKey(registrationNumber))
            {
                cars.Remove(registrationNumber);
                Count--;
            }
        }
    }
}