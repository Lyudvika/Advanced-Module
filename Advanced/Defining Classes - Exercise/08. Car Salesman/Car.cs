using System.Text;

namespace DefiningClasses;
public class Car
{
    //fields
    private string model;
    private Engine engine;
    private int weight;
    private string color;

    //constructor
    public Car(string model, Engine engine, int weight, string color)
    {
        Model = model;
        Engine = engine;
        Weight = weight;
        Color = color;
    }

    //properties
    public string Model { get { return model; } set { model = value; } }
    public Engine Engine { get { return engine; } set { engine = value; } }
    public int Weight { get { return weight; } set { weight = value; } }
    public string Color { get { return color; } set { color = value; } }

    //methods
    public override string ToString()
    {
        StringBuilder text = new StringBuilder();
        text.AppendLine($"{Model}: ");
        text.AppendLine($"  {Engine.Model}:");
        text.AppendLine($"    Power: {Engine.Power}");
        if (Engine.Displacement == default)
        {
            text.AppendLine($"    Displacement: n/a");
        }
        else
        {
            text.AppendLine($"    Displacement: {Engine.Displacement}");
        }
        text.AppendLine($"    Efficiency: {Engine.Efficiency}");
        if (Weight == default)
        {
            text.AppendLine($"  Weight: n/a");
        }
        else
        {
            text.AppendLine($"  Weight: {Weight}");
        }
        text.AppendLine($"  Color: {Color}");

        return text.ToString();
    }
}