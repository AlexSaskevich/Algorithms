namespace RecursiveBinarySearch;

internal static class Program
{
    private static void Main()
    {
        int[] numbers = [-4, -3, 0, 1, 18, 523];

        const int toFind = 1;

        int index = FindElementIndex(numbers, 0, numbers.Length - 1, toFind);

        Console.WriteLine($"{toFind} is present at index {index}");
    }

    private static int FindElementIndex(in int[] array, int left, int right, int toFind)
    {
        if (left > right)
        {
            return -1;
        }

        int middle = (left + right) / 2;

        if (array[middle] == toFind)
        {
            return middle;
        }

        return array[middle] < toFind
            ? FindElementIndex(array, middle + 1, right, toFind)
            : FindElementIndex(array, left, middle - 1, toFind);
    }
}