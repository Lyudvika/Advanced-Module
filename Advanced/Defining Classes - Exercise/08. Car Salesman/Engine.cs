namespace DefiningClasses;
public class Engine
{
    //constructor
    public Engine(string model, int power, int displacement, string efficiency)
    {
        Model = model;
        Power = power;
        Displacement = displacement;
        Efficiency = efficiency;
    }

    //properties
    public string Model { get; set; }
    public int Power { get; set; }
    public int Displacement { get; set; }
    public string Efficiency { get; set; }
}