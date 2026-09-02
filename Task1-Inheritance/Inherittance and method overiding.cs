using System;

// Base class
class Animal
{
    // Virtual method that can be overridden by derived classes
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

// Derived class
class Dog : Animal
{
    // Override the MakeSound method
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

// Derived class
class Cat : Animal
{
    // Override the MakeSound method
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the base class
        Animal animal = new Animal();

        // Create an instance of the Dog class
        Dog dog = new Dog();

        // Create an instance of the Cat class
        Cat cat = new Cat();

        // Call MakeSound() on each object
        animal.MakeSound();
        dog.MakeSound();
        cat.MakeSound();

        Console.ReadLine();
    }
}