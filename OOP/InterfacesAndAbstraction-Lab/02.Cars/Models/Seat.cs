using Cars.Models.Interfaces;
using System.Text;

namespace Cars.Classes;

public class Seat : ICar
{
    public Seat(string model, string color)
    {
        Model = model;
        Color = color;
    }

    public string Model { get; set; }
    public string Color { get; set; }

    public string Start()
        => $"Engine start";
    public string Stop()
        => $"Breaaak!";

    public override string ToString()
    {
        StringBuilder stringBuilder = new();
        stringBuilder.AppendLine($"{Color} Seat {Model}");
        stringBuilder.AppendLine(Start());
        stringBuilder.AppendLine(Stop());

        return stringBuilder.ToString().TrimEnd();
    }
}