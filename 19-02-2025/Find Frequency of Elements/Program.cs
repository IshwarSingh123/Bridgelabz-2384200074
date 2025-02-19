namespace Find_Frequency_of_Elements;

class MyClass
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>() { "apple", "banana", "apple", "orange" }
;


        FindFrequency findFrequency = new FindFrequency();

        Dictionary<string, int> dict = new Dictionary<string, int>();
        dict = findFrequency.FrequencyFind(list);
        foreach (var item in dict)
        {
            Console.Write($"{item.Key} : {item.Value} ");
        }

    }
}
