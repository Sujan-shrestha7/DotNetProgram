// Base class
using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Barking...");
    }
}
class Cat : Animal
{
    public void Sleep()
    {
        Console.WriteLine("Sleeping...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cat c = new Cat();
        c.Eat();
        c.Sleep();
        Console.ReadKey();
    }
}
