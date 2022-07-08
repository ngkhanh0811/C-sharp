using System;
class Animals
{
    public void Eats()
    {
        Console.WriteLine("Every animal eats somethings.");
    }
    public void DoSomeThing()
    {
        Console.WriteLine("Every animal do somethings.");
    }
}
class Cat : Animals
{
    static void Main(string[] args)
    {
        Cat objCat = new Cat();
        objCat.Eats();
        objCat.DoSomeThing();
    }
}