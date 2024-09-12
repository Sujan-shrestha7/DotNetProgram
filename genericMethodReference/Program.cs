using System;
using System.Collections.Generic;
namespace genericMethodReference
{
    internal class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        } 
        static void Main(string[] args)
        {
            int a=40; int b=60;
            Console.WriteLine("before swap : {0},{1}", a, b);
            Swap<int>(ref a, ref b);
            Console.WriteLine($"After Swapping:{a} ,{b}");
            Console.ReadLine();
        }
    }
}
