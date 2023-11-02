public class StartUp
{
    static void Main(string[] args)
    {
        List<int> universe = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
        int numOfSets = int.Parse(Console.ReadLine());
        List<int[]> sets = new();

        for (int i = 0; i < numOfSets; i++)
        {
            sets.Add(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
        }

        List<int[]> bestSets = ChooseSets(sets, universe);

        Console.WriteLine($"Sets to take ({bestSets.Count}):");

        foreach (int[] subSet in bestSets)
        {
            Console.WriteLine("{ " + string.Join(", ", subSet) + " }");
        }
    }
    public static List<int[]> ChooseSets(List<int[]> sets, List<int> universe)
    {
        List<int[]> selectedSets = new();

        while (universe.Count > 0)
        {
            int[] current = sets.OrderByDescending(set => set.Count(universe.Contains)).First();
            selectedSets.Add(current);
            sets.Remove(current);

            foreach (int i in current)
            {
                universe.Remove(i);
            }

        }
        return selectedSets;
    }
}