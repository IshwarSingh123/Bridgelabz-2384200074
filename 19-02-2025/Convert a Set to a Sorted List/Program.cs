class MyClass
{

    public static List<int> SetToSortedList(HashSet<int> set)
    {
        List<int> list = new List<int>(set);
        list.Sort();
        return list;
    }
    static void Main(string[] args)
    {
        HashSet<int> set = new HashSet<int>();

        Console.WriteLine("Enter numbers separated by space:");
        string input = Console.ReadLine(); // Read input as a string

        string[] elements = input.Split(' '); // Split input by spaces
        foreach (string ele in elements)
        {
            if (int.TryParse(ele, out int num)) // Convert to integer
            {
                set.Add(num); // Add to HashSet (duplicates are ignored)
            }
        }


        List<int> list = new List<int>();
        list = SetToSortedList(set);
        foreach (int i in list)
        {
            Console.Write(i+" ");
        }

    }
}