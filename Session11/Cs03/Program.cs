using System;
using System.Collections.Generic;

class Employee
{
    string _empName;
    int _empID;
    public Employee(string empName, int num)
    {
        _empName = empName;
        _empID = num;
    }  
    public string Name
    {
        get
        {
            return _empName;
        }
    }
    public int ID
    {
        get
        {
            return _empID;  
        }
    }
}

class GenericList<T> where T : Employee
{
    T[] _name = new T[3];
    int _counter = 0;
    public void Add(T val)
    {
        _name[_counter] = val;
        _counter++;
    }
    public void Display()
    {
        for(int i = 0; i < _counter; i++)
        {
            Console.WriteLine(_name[i] + "." + _name[i].ID);
        }
    }
}

class ClassContrainsDemo
{
    static void Main(string[] args)
    {
        GenericList<Employee> objList = new GenericList<Employee>();
        objList.Add(new Employee("John", 100));
        objList.Add(new Employee("Patrick", 20));
        objList.Display();
    }
}