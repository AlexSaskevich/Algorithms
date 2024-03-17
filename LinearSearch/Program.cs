namespace LinearSearch;

internal static class Program
{
    private static void Main()
    {
        List<string> names = ["Vladimir", "Alex", "Boris"];

        const string toFind = "Alex";
        
        int index = FindElementIndex(names, toFind);

        Console.WriteLine($"{toFind} is present at index {index}");
    }

    private static int FindElementIndex<T>(IList<T> collection, T toFind)
    {
        for (int i = 0; i < collection.Count; i++)
        {
            T value = collection[i];

            if (Equals(value, toFind))
            {
                return i;
            }
        }

        return -1;
    }
}