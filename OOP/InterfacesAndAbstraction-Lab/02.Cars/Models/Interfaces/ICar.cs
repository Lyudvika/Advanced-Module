namespace Cars.Models.Interfaces;

public interface ICar
{
    public string Model { get; set; }
    public string Color { get; set; }
    public string Start();
    public string Stop();
}