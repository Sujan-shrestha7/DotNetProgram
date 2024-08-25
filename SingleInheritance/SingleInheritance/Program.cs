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

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        myDog.Eat();
        myDog.Bark();
        Console.ReadKey();
    }
}
