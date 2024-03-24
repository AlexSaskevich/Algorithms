namespace SelectionSort;

internal static class Program
{
    private static void Main()
    {
        int[] numbers = [5, 2, 9, 3, -5, 3];

        ShowArray(numbers);

        SelectionSort(numbers, numbers.Length);

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

    private static void SelectionSort(int[] array, int length)
    {
        for (int i = 0; i < length; i++)
        {
            int smallest = i;

            for (int j = i + 1; j < length; j++)
            {
                if (array[j] < array[smallest])
                {
                    smallest = j;
                }
            }

            (array[i], array[smallest]) = (array[smallest], array[i]);
        }
    }
}