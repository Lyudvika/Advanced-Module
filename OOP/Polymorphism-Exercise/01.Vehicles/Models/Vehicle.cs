using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public class Vehicle : IVehicle
    {
        private double increaseedConsumption;
        protected Vehicle(double fuelQuantity, double fuelConsumption, double increaseedConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            this.increaseedConsumption = increaseedConsumption;
        }

        public double FuelQuantity {get; private set;}

        public double FuelConsumption { get; private set; }

        public string Drive(double distance)
        {
            double consumption = FuelConsumption + increaseedConsumption;

            if (FuelQuantity < distance * consumption)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }

            FuelQuantity -= distance * consumption;

            return $"{this.GetType().Name} travelled {distance} km";
        }

        public virtual void Refuel(double amount)
            => FuelQuantity += amount;

        public override string ToString()
            => $"{this.GetType().Name}: {FuelQuantity:f2}";
    }
}
