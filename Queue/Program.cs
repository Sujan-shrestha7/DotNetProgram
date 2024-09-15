using System;
using System.Collections.Generic;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queu = new Queue<string>();
            queu.Enqueue("a");
            queu.Enqueue("ag");
            queu.Enqueue("afg");
            queu.Enqueue("afgh");
            queu.Enqueue("avbnm");
            Console.WriteLine("The elements are:");
            foreach (string item in queu)
            {
                Console.WriteLine(item);
            }
            queu.Dequeue();

            Console.WriteLine("after removing :");
        }
    }
}
