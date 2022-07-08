using System;
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Every an animal eat somethings.");
    }
}

class Mammal:Animal
{
    public void Feature()
    {
        Console.WriteLine("Mammals give birth to young ones.");
    }
}

class Dog : Mammal
{
    public void Noise()
    {
        Console.WriteLine("Dog Barks.");
    }

    static void Main(string[] args)
    {
        Dog objDog = new Dog();
        objDog.Eat();
        objDog.Feature();
        objDog.Noise();
    }
}