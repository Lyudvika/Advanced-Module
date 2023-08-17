namespace CarManufacturer
{
    public class StartUp
    {
        public const string Seperator = " ";
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            string command;
            while ((command = Console.ReadLine()) != "No more tires")
            {
                string[] tireInfo = command.Split(Seperator, StringSplitOptions.RemoveEmptyEntries);
                var tire = new List<Tire>();

                for (int i = 0; i < tireInfo.Length; i += 2)
                {
                    var year = int.Parse(tireInfo[i]);
                    var pressure = double.Parse(tireInfo[i + 1]);
                    var newTire = new Tire(year, pressure);
                    tire.Add(newTire);
                }

                tires.Add(tire.ToArray());
            }

            while ((command = Console.ReadLine()) != "Engines done")
            {
                string[] engineInfo = command.Split(Seperator, StringSplitOptions.RemoveEmptyEntries);
                int horsePower = int.Parse(engineInfo[0]);
                double cubicCapacity = double.Parse(engineInfo[1]);

                Engine engine = new Engine(horsePower, cubicCapacity);
                engines.Add(engine);
            }

            while ((command = Console.ReadLine()) != "Show special")
            {
                string[] carInfo = command.Split(Seperator, StringSplitOptions.RemoveEmptyEntries);
                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                int engineIndex = int.Parse(carInfo[5]);
                int tiresIndex = int.Parse(carInfo[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]);
                cars.Add(car);
            }

            cars = cars.Where(y => y.Year >= 2017)
                .Where(h => h.Engine.HorsePower > 330)
                .Where(t => t.Tires.Sum(x => x.Pressure) > 9 && t.Tires.Sum(x => x.Pressure) < 10)
                .ToList();

            foreach (Car car in cars)
            {
                car.Drive(20);
                Console.WriteLine(car);
            }
        }
    }
}