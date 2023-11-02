public class StartUp
{
    private static void Main(string[] args)
    {
        int[] inputNums = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        QuickSortHelper(inputNums, 0, inputNums.Length - 1);
        Console.WriteLine(string.Join(" ", inputNums));
    }

    public static void QuickSortHelper(int[] array, int startIdx, int endIdx)
    {
        if (startIdx >= endIdx)
            return;

        int pivotIdx = startIdx;
        int leftIdx = startIdx + 1;
        int rightIdx = endIdx;

        while (leftIdx <= rightIdx)
        {
            if (array[leftIdx] > array[pivotIdx] && array[rightIdx] < array[pivotIdx])
            {
                Swap(array, leftIdx, rightIdx);
            }

            if (array[leftIdx] <= array[pivotIdx])
            {
                leftIdx += 1;
            }

            if (array[rightIdx] >= array[pivotIdx])
            {
                rightIdx -= 1;
            }

        }

        Swap(array, pivotIdx, rightIdx);

        if (rightIdx - 1 - startIdx < endIdx - (rightIdx + 1))
        {
            QuickSortHelper(array, startIdx, rightIdx - 1);
            QuickSortHelper(array, rightIdx + 1, endIdx);
        }
        else
        {
            QuickSortHelper(array, rightIdx + 1, endIdx);
            QuickSortHelper(array, startIdx, rightIdx - 1);
        }
    }

    public static void Swap(int[] array, int pivotIdx, int rightIdx)
        => (array[rightIdx], array[pivotIdx]) = (array[pivotIdx], array[rightIdx]);
}