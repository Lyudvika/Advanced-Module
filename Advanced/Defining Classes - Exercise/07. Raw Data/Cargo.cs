namespace DefiningClasses;
public class Cargo
{
    public Cargo(int cargoWeight, string cargoType)
    {
        Type = cargoType;
        Weight = cargoWeight;
    }

    public string Type { get; set; }
    public int Weight { get; set; }
}