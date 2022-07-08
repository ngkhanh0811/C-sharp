using System;

class Animals
{
    public Animals()
    {
        Console.WriteLine("Animal constructor without parameters");
    }
    public Animals(string name)
    {
        Console.WriteLine("Animals constructor with a string parameter");
    }
    class Canine : Animals
    {
        public Canine():base("Lion"){
            Console.WriteLine("Derived Canine");
            }
    }
class Details
{
    static void Main(string[] args)
    {
        Canine objCanine = new Canine();
    }
}