using System;

class Onepiece
{
    protected string name = "Zoro";
    protected string weapon = "Sword";
    protected int id = 2;
    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Weapon: " + weapon);
        Console.WriteLine("ID: " + id);
    }
}

class Person : Onepiece
{
    string name = "Luffy";
    string weapon = "Punch";
    int id = 1;
   new void Display()
    {
        base.Display();
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Weapon: " + weapon);
        Console.WriteLine("ID: "+id);
    }

    static void Main(string[] args)
    {
        Person p = new Person();
        p.Display();
    }
}