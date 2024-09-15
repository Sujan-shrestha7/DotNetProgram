using System;
using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Dictionary<int, string> obj = new Dictionary<int, string>(5);

            obj.Add(0, "xcvbnm,.");
            obj.Add(1, "bb,.");
            obj.Add(2, "bb,.");
            obj.Add(3, "bb,.");
            obj.Add(4, "bbsdg,.");
            for (int i = 0; i < obj.Count; i++)
            {
                Console.WriteLine(obj[i]);
            }
            Console.ReadKey();
        }
    }
}
