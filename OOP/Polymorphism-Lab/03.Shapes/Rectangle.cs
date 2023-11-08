﻿namespace Shapes;

public class Rectangle : Shape
{
    private double height;
    private double width;

    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }

    public double Height 
    {
        get => height;
        private set => height = value;
    }
    public double Width
    {
        get => width;
        private set => width = value;
    }

    public override double CalculateArea()
            => height * width;

    public override double CalculatePerimeter()
            => (height + width) * 2;
}