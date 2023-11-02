namespace SumOfCoins
{
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<int> coins = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderByDescending(c => c)
                .ToList();
            int desiredSum = int.Parse(Console.ReadLine());

            Dictionary<int, int> coinsTaken = ChooseCoins(coins, desiredSum);

            if (coinsTaken.Count == 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine($"Number of coins to take: {coinsTaken.Sum(c => c.Value)}");

                foreach (var coin in coinsTaken)
                {
                    Console.WriteLine($"{coin.Value} coin(s) with value {coin.Key}");
                }
            }
        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            Dictionary<int, int> coinsTaken = new Dictionary<int, int>();

            while (targetSum != 0)
            {
                if (targetSum < coins.Min())
                {
                    coinsTaken.Clear();
                    return coinsTaken;
                }

                for (int i = 0; i < coins.Count; i++)
                {
                    if (coins[i] <= targetSum)
                    {
                        targetSum -= coins[i];

                        if (!coinsTaken.ContainsKey(coins[i]))
                        {
                            coinsTaken.Add(coins[i], 0);
                        }

                        coinsTaken[coins[i]]++;

                        break;
                    }
                }
            }

            return coinsTaken;
        }
    }
}