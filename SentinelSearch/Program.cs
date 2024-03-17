namespace SentinelSearch;

internal static class Program
{
    private static void Main()
    {
        int[] numbers = [13, 41650, 34, -23, 0, -43, 234, 1, 555];

        const int toFind = 0;

        int index = FindElementIndex(numbers, numbers.Length, toFind);

        Console.WriteLine($"{toFind} is present at index {index}");
    }

    private static void ShowCollection<T>(IEnumerable<T> enumerable)
    {
        foreach (T element in enumerable)
        {
            Console.WriteLine($"{element}");
        }
    }

    private static int FindElementIndex<T>(IList<T> collection, int collectionLength, T toFind)
    {
        T lastElement = collection[collectionLength - 1];
        collection[collectionLength - 1] = toFind;

        int i = 0;

        while (Equals(collection[i], toFind) == false)
        {
            i++;
        }

        collection[collectionLength - 1] = lastElement;

        if (i < collectionLength - 1 || Equals(collection[collectionLength - 1], toFind))
        {
            return i;
        }

        return -1;
    }
}