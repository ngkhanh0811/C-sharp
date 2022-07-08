using System;
class Animals
{
    protected string Food;
    protected string Activity;
}

class Cat : Animals
{
    static void Main(string[] args)
    {
        Cat objCat = new Cat();
        objCat.Food = "Mouse";
        objCat.Activity = "laze around";
        Console.WriteLine("The Cat loves to eat" + objCat.Food);
        Console.WriteLine("The Cat loves to " + objCat.Activity);   
    }
}