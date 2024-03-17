namespace BinarySearch;

internal static class Program
{
    private static void Main()
    {
        int[] numbers = [-4, -3, 0, 1, 18, 523];

        const int toFind = 198484;

        int index = FindElementIndex(numbers, toFind);

        Console.WriteLine($"{toFind} is present at index {index}");
    }

    private static int FindElementIndex(in int[] array, int toFind)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int middle = (left + right) / 2;

            if (array[middle] == toFind)
            {
                return middle;
            }

            if (array[middle] < toFind)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }

        return -1;
    }
}