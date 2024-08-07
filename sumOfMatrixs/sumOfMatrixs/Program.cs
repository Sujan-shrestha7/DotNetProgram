using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfMatrixs
{
    internal class Program
    {
        static void Main(string[] args)

        {
           // int a=int.Parse(Console.ReadLine("));
            int[,] values = new int[4, 2]
            {
                { 9,99},
                { 3,33},
                { 4,44},
                { 1,11}
        };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(values[i,j]);
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}