using System;

// Interface 1
interface IAnimal
{
    void Eat();
}

// Interface 2
interface IPet
{
    void Play();
}

// Class implementing both interfaces
class Dog : IAnimal, IPet
{
    public void Eat()
    {
        Console.WriteLine("Dog is eating");
    }

    public void Play()
    {
        Console.WriteLine("Dog is playing");
    }

    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();

        dog.Eat();  // From IAnimal
        dog.Play(); // From IPet
        dog.Bark(); // From Dog

        Console.ReadKey();

    }
}
