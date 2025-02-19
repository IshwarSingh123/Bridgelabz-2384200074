using System.Collections.Generic;
using Rotate_Elements_in_a_List;

class MyClass
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        Console.WriteLine("Enter the elements:");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "stop")
            {
                break;
            }
            if (int.TryParse(input, out int intValue))
            {
                list.Add(intValue);
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter an integer.");
            }
        }
        Console.WriteLine("Enter rotate by:");
        int rotate = int.Parse(Console.ReadLine());

        RotateElement rotateElement = new RotateElement();

        List<int> list2 = rotateElement.ElementsRotate(list, rotate);

        foreach (var item in list2)
        {
            Console.Write(item+" ");
        }
    }
}