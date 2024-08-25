using System;

// Base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

// Derived class 1
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

// Derived class 2
class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Cat is meowing");
    }
}

// Derived class 3
class Cow : Animal
{
    public void Moo()
    {
        Console.WriteLine("Cow is mooing");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Eat();  // Inherited from Animal
        dog.Bark(); // Specific to Dog

        Cat cat = new Cat();
        cat.Eat();  // Inherited from Animal
        cat.Meow(); // Specific to Cat

        Cow cow = new Cow();
        cow.Eat();  // Inherited from Animal
        cow.Moo();  // Specific to Cow

        Console.ReadKey();
    }
}
