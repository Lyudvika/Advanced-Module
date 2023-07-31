List<double> prices = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
Func<double, double> priceWithVat = (price) => price * 1.2;

prices.ForEach(price => Console.WriteLine($"{priceWithVat(price):f2}"));