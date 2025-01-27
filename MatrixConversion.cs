using System;

class MatrixConversion
{
    static void Main(string[] args)
    {
			int rows = 0, columns = 0;
        
        
            // Take user input 
            Console.WriteLine("Enter the number of rows: ");
            rows = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the number of columns: ");
            columns = int.Parse(Console.ReadLine());
 

			// Create a 2D array
			int[,] matrix = new int[rows, columns];

			// Take user input to fill the 2D array
			Console.WriteLine("Enter the elements of the matrix:");
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					Console.WriteLine("Enter element at [" + i + "," + j + "]");
					matrix[i, j] = int.Parse(Console.ReadLine());
				}
			}

			// Create a 1D array to store the elements of the 2D array
			int[] array = new int[rows * columns];

			// Define the index variable
			int index = 0;

			// Copy elements from the 2D array to the 1D array
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					array[index] = matrix[i, j];
					index++;
				}
			}

			// Display the 1D array
			Console.WriteLine("The elements in the 1D array are:");
			foreach (int value in array)
			{
				Console.Write(value + " ");
			}
		}
	}
