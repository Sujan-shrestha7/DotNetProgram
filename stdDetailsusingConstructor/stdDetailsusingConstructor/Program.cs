using System;
using System.Net;
using System.Xml.Linq;

namespace stdDetailsusingConstructor
{
    internal class Program
    {

        public int ID;
        public string Name;
        public string Address;

        public void Students()
        {
            ID= 11;
            Name = "John rai";
            Address = "hello";

            Console.WriteLine($"the id is {ID}.");
            Console.WriteLine($"the name is {Name}.");
            Console.WriteLine($"the address is {Address}.");
        }

        public void Students(int id, String name, string address)
        {
            ID = id;
            Name = name;
            Address = address;
            DisplayDetails();
        }
        public void DisplayDetails()
        {
            Console.WriteLine("\n......Student Details......");
            Console.WriteLine($"the id is {ID}.");
            Console.WriteLine($"the name is {Name}.");
            Console.WriteLine($"the address is {Address}.\n\n");
        }
        static void Main(string[] args)
        {
               Program obj = new Program();
            Console.WriteLine("enter student id:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter name of students");
            String s = Console.ReadLine();

            Console.WriteLine("enter address:");
            String d=Console.ReadLine();

            obj.Students(a, s, d);
            obj.Students();
            Console.ReadKey();
        }
    }
}
