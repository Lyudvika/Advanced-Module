namespace DefiningClasses;
public class Car
{
    //fields
    private string model;
    private Engine engine;
    private Cargo cargo;
    private Tire[] tires;

    //constructor
    public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
    {
        Model = model;
        Engine = engine;
        Cargo = cargo;
        Tires = tires;
    }

    //properties
    public string Model { get { return model; } set { model = value; } }
    public Engine Engine { get { return engine; } set { engine = value; } }
    public Cargo Cargo { get { return cargo; } set { cargo = value; } }
    public Tire[] Tires { get { return tires; } set { tires = value; } }
}