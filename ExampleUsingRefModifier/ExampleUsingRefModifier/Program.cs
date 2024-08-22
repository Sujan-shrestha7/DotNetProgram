using System;

namespace ExampleUsingRefModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number:");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number:");
            int b=int.Parse(Console.ReadLine());

            Console.WriteLine($"the number before swapping are: {a}{b} ");

            SwapNumbers(ref a, ref b);
            Console.WriteLine($"After swapping: Number1 = {a}, Number2 = {b}");
            Console.ReadKey();
        }

        static void SwapNumbers(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}
