using System;

// Base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

// Another base class (using an interface instead of a class)
interface IWalkable
{
    void Walk();
}

// Derived class from Animal and implementing IWalkable
class Dog : Animal, IWalkable
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }

    // Implementation of the Walk method from the IWalkable interface
    public void Walk()
    {
        Console.WriteLine("Dog is walking");
    }
}

// Another derived class
class Labrador : Dog
{
    public void Run()
    {
        Console.WriteLine("Labrador is running");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Labrador labrador = new Labrador();

        // Accessing methods from different levels of inheritance
        labrador.Eat();  // From Animal
        labrador.Bark(); // From Dog
        labrador.Walk(); // From IWalkable (through Dog)
        labrador.Run();  // From Labrador
        Console.ReadKey();
    }
}
