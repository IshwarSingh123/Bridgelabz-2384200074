using System;

class ArrayManipulation
{
    public string ConvertArrayToString(int[] array)
    {
        return string.Join(", ", array);
    }
    
    public void SortArray(int[] array)
    {
		//sort the array in ascending order
        Array.Sort(array);
    }
    
    public int SearchElement(int[] array, int element)
    {
		//use of binary search
        return Array.BinarySearch(array, element);
    }

    public static void Main()
    {
        ArrayManipulation arrayObj = new ArrayManipulation();

        Console.WriteLine("Enter the number of elements in the array:");
        int n = Convert.ToInt32(Console.ReadLine());
        
        int[] array = new int[n];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        string arrayAsString = arrayObj.ConvertArrayToString(array);
        Console.WriteLine("Array as string: " + arrayAsString);
        
        arrayObj.SortArray(array);
        Console.WriteLine("Sorted Array: " + arrayObj.ConvertArrayToString(array));

        Console.WriteLine("Enter an element to search in the sorted array:");
        int elementToSearch = Convert.ToInt32(Console.ReadLine());
        
        int index = arrayObj.SearchElement(array, elementToSearch);
        
        if (index >= 0)
        {
            Console.WriteLine("Element " + elementToSearch + " found at index: " + index);
        }
        else
        {
            Console.WriteLine("Element " + elementToSearch + " not found.");
        }
    }
}
