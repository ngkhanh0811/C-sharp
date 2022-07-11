using System;
using System.Collections.Generic;

interface IDetails
{
    void GetDetails();
}

class Students : IDetails
{
    string _stuName;
    int _stuID;
    public Students(string stuName, int stuID)
    {
        _stuName = stuName;
        _stuID = stuID;
    }   
    public void GetDetails()
    {
        Console.WriteLine(_stuID + "\t" + _stuName);
    }
}
class GenericList<T> where T : IDetails
{
    T[] _values = new T[3];
    int _counter = 0;
    public void Add(T val)
    {
        _values[_counter] = val;
        _counter++;
    }
    public void Display()
    {
        for(int i=0; i<3; i++)
        {
            _values[i].GetDetails();
        }
    }
}

class InterfaceConstraintDemo
{
    static void Main(string[] args)
    {
        GenericList<Students> objList = new GenericList<Students>();
        objList.Add(new Students("Wilson", 120));
        objList.Add(new Students("Patrick", 125));
        objList.Add(new Students("Charlie", 130));
        objList.Display();
    }
}