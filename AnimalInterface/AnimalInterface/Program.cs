using System;

interface IAnimal
{
    void Drink();
}
interface ICarnivorous
{
    void Eat();
}
interface IReptile : IAnimal, ICarnivorous
{
    void Habitat();
}
class Crocodile : IReptile
{
    public void Drink()
    {
        Console.WriteLine("Drinks fresh water");
    }
    public void Habitat()
    {
        Console.WriteLine("Can stay in Water and Land");
    }
    public void Eat()
    {
        Console.WriteLine("Eats Flesh");
    }
    static void Main(string[] args)
    {
        Crocodile objCro = new Crocodile();
        Console.WriteLine(objCro.GetType().Name);
        objCro.Eat();
        objCro.Drink();
        objCro.Habitat();
    }
}