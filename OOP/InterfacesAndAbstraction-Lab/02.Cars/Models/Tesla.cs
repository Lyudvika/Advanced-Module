using Cars.Models.Interfaces;
using System.Text;

namespace Cars.Classes;

public class Tesla :ICar, IElectricCar
{
    public Tesla(string model, string color, int battery)
    {
        Model = model;
        Color = color;
        Battery = battery;
    }

    public string Model { get; set; }
    public string Color { get; set; }
    public int Battery { get; set; }
    public string Start()
        => $"Engine start";
    public string Stop()
        => $"Breaaak!";

    public override string ToString()
    {
        StringBuilder stringBuilder = new();
        stringBuilder.AppendLine($"{Color} Tesla {Model} with {Battery} Batteries");
        stringBuilder.AppendLine(Start());
        stringBuilder.AppendLine(Stop());

        return stringBuilder.ToString().TrimEnd();
    }
}