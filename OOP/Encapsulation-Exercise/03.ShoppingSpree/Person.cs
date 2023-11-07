namespace ShoppingSpree;

public class Person
{
    private const string NameExceptionMessage = "Name cannot be empty";
    private const string MoneyExceptionMessage = "Money cannot be negative";
    private const decimal MinMoney = 0;

    private string name;
    private decimal money;
    private List<Product> bagOfProducts;

    public Person(string name, decimal money)
    {
        Name = name;
        Money = money;
        bagOfProducts = new List<Product>();
    }

    public string Name
    {
        get => name;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(NameExceptionMessage);
            }

            name = value;
        }
    }

    public decimal Money
    {
        get => money;
        private set
        {
            if (value < MinMoney)
            {
                throw new ArgumentException(MoneyExceptionMessage);
            }

            money = value;
        }
    }

    public string Add(Product product)
    {
        if (Money < product.Cost)
            return $"{Name} can't afford {product.Name}";

        bagOfProducts.Add(product);
        Money -= product.Cost;

        return $"{Name} bought {product.Name}";
    }

    public override string ToString()
    {
        string products = bagOfProducts.Any()
            ? string.Join(", ", bagOfProducts.Select(p => p.Name))
            : "Nothing bought";

        return $"{Name} - {products}";
    }
}