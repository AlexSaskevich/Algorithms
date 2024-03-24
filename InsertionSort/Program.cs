namespace InsertionSort;

internal static class Program
{
    private static void Main()
    {
        int[] numbers = [5, 2, 9, 3, -5, 3];

        ShowArray(numbers);

        InsertionSort(numbers);

        ShowArray(numbers);
    }

    private static void ShowArray(IEnumerable<int> array)
    {
        Console.WriteLine();

        foreach (int value in array)
        {
            Console.Write($"{value} ");
        }
    }

    private static void InsertionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                if (array[j] < array[j - 1])
                {
                    (array[j - 1], array[j]) = (array[j], array[j - 1]);
                }
            }
        }
    }
}