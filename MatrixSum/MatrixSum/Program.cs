using System;

class MatrixSum
{
    static void Main()
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of columns: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] matrix1 = new int[rows, columns];
        int[,] matrix2 = new int[rows, columns];

        Console.WriteLine("Enter elements of the first matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter elements of the second matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int[,] sumMatrix = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        Console.WriteLine("Sum of the two matrices:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(sumMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();  
    }
}
