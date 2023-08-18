using System.Reflection;
using System.Text;

namespace SoftUniParking;
public class Car
{
    //constructors
    public Car(string make, string model, int horsePower, string regustrationNumber) 
    { 
        Make = make;
        Model = model;
        HorsePower = horsePower;
        RegistrationNumber = regustrationNumber;
    }

    //properties
    public string Make { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
    public string RegistrationNumber { get; set; }

    //methods
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"Make: {Make}");
        sb.AppendLine($"Model: {Model}");
        sb.AppendLine($"HorsePower: {HorsePower}");
        sb.AppendLine($"RegistrationNumber: {RegistrationNumber}");

        return sb.ToString().TrimEnd();
    }
}