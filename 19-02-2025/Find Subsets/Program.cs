class MyClass
{

    public bool SubsetFind(HashSet<int> set1,HashSet<int> set2)
    {
        foreach (int num in set1)
        {
            if (!set2.Contains(num))
            {
                return false;
            }
        }
        return true;
    }
    static void Main(string[] args)
    {
        MyClass myClass = new MyClass();
        HashSet<int> set1 = new HashSet<int>();
        HashSet<int> set2= new HashSet<int>();

        Console.WriteLine("Enter Elements of First Set:");
        string [] elementsOfSet1 = Console.ReadLine().Split(" ");
       
        foreach (var item in elementsOfSet1)
        {
            if (int.TryParse(item, out int num))
            {
                set1.Add(num);
            }
        }

        Console.WriteLine("Enter Elements of Second Set:");
        string[] elementsOfSet2 = Console.ReadLine().Split(" ");

        foreach (var item in elementsOfSet2)
        {
            if (int.TryParse(item, out int num))
            {
                set2.Add(num);
            }
        }

        Console.WriteLine("------Check set1 is the subset2 or not ?0----");
        bool result = myClass.SubsetFind(set1, set2);
        Console.WriteLine("-------------After processing ---------------");
        if (result)
        {
            Console.WriteLine("Set1 is the subset of set2");
        }
        else
        {
            Console.WriteLine("Set1 is not the subset of set2");
        }
    }
}