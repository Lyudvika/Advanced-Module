namespace ShoppingSpree;

public class Product
{
    private const string NameExceptionMessage = "Name cannot be empty";
    private const string CostExceptionMessage = "Money cannot be negative";
    private const decimal MinCost = 0;

    private string name;
    private decimal cost;

    public Product(string name, decimal cost)
    {
        Name = name;
        Cost = cost;
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
    public decimal Cost
    {
        get => cost;
        private set 
        { 
            if (value < MinCost)
            {
                throw new ArgumentException(CostExceptionMessage);
            }

            cost = value;
        }
    }
}