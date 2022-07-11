using System;
using System.Collections.Generic;
using System.Collections;

class General<T, U>
{
    T _valOne;
    U _valTwo;
    public void AcceptValue(T item)
    {
        _valOne = item;
    }

    public void AcceptValue(U item)
    {
        _valTwo = item;
    }

    public void Display()
    {
        Console.Write(_valOne + "\t" + _valTwo);
    }
}
class MethodOverload
{
    static void Main(string[] args)
    {
        General<int, string> objGenOne = new General<int, string>();
        objGenOne.AcceptValue(10);
        objGenOne.AcceptValue("Smith");
        Console.WriteLine("ID\tName\tDesignation\tSalary");
        objGenOne.Display();
        General<string, float> objGenTwo = new General<string, float>();
        objGenTwo.AcceptValue("Mechanic");
        objGenTwo.AcceptValue(2500);
        Console.Write("\t");
        objGenTwo.Display();
        Console.WriteLine();
    }
}