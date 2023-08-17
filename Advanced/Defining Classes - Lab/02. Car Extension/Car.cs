using System.Text;

namespace CarManufacturer
{
    internal class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public string Make { get { return make; } set { make = value; } }

        public string Model { get { return model; } set { model = value; } }

        public int Year { get { return year; } set {  year = value; } }

        public double FuelQuantity { get {  return fuelQuantity; } set {  fuelQuantity = value; } }

        public double FuelConsumption { get {  return fuelConsumption; } set { fuelConsumption = value; } }

        public void Drive(double distance)
        {
            double fuelNeeded = distance * fuelConsumption;

            if (fuelNeeded < fuelQuantity)
            {
                fuelNeeded -= fuelQuantity;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            StringBuilder sb = new();

            sb.AppendLine($"Make: {this.Make}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Year: {this.Year}");
            sb.AppendLine($"Fuel: {this.fuelQuantity:f2}");

            return sb.ToString();
        }
    }
}
