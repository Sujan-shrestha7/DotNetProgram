using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverloading
{
    internal class Program
    {

        void Animal(String Name, String color)
        {
            Console.WriteLine($"The Name is : {Name} \n color is: {color}");
        }
        void Animal(String Name, String eats, int age)
        {
            Console.WriteLine($"The Name is : {Name}\n eats: {eats} and age is:{age}");
        }
        static void Main(string[] args)
        {
            Program obr = new Program();
            obr.Animal("Dog", "White");
            obr.Animal("Buffalo", "Bread",17);
            Console.ReadKey();
        }
    }
}
