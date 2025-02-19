namespace Remove_Duplicates_While_Preserving_Order;
class MyClass
{
    static void Main(string[] args)
    {
        DuplicateRemove duplicateRemove = new DuplicateRemove();
        Console.WriteLine("Enter the Elements in a List:");
        List<int> list = new List<int>(Array.ConvertAll(Console.ReadLine().Split(" ") ,int.Parse));

        List<int> result = duplicateRemove.RemoveDuplicates(list);
        Console.WriteLine("After remove Duplicates:");
        foreach (int item in result)
        {
            Console.Write(item+" ");
        }
    }
}