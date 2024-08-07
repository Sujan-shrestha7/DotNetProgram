using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of jagged arrays: ");
        int n = int.Parse(Console.ReadLine());
        int[][] jaggedArray = new int[n][];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter the length of {i + 1} array : ");
            int lengthOfArray = int.Parse(Console.ReadLine());
            jaggedArray[i] = new int[lengthOfArray];

            for (int j = 0; j < lengthOfArray; j++)
            {
                Console.Write($"Enter element {j + 1} of sub-array {i + 1}: ");
                jaggedArray[i][j] = int.Parse(Console.ReadLine());
            }
        }
        int sum = 0;
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                sum += jaggedArray[i][j];
            }
        }
        Console.WriteLine("Sum of all elements in the jagged array: " + sum);
        Console.ReadKey();
    }
}
