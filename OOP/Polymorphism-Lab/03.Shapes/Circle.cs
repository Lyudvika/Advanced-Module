namespace Shapes;

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Radius
    {
        get => radius;
        private set => radius = value;
    }

    public override double CalculateArea()
            => Math.PI * radius * radius;

    public override double CalculatePerimeter()
            => 2 * Math.PI * radius;
}