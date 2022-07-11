using System;
using System.Collections.Generic;
using System.Collections;

class GeneralList<T>
{
    protected T ItemOne;
    public GeneralList(T valOne)
    {
        ItemOne = valOne;
    }

    public virtual T GetValue()
    {
        return ItemOne;
    }
}

class Student<T> : GeneralList<T>
{
    public T value;
    public Student(T valOne, T valTwo) : base(valOne)
    {
        value = valTwo;
    }

    public override T GetValue() {
        Console.Write(base.GetValue() + "\t\t");
        return value;
    }   
}
class StudentList
{
    public static void Main(string[] args)
    {
        Student<string> objStu = new Student<string>("Patrick", "Male");
        Console.WriteLine("Name\t\tSex");
        Console.WriteLine(objStu.GetValue());
    }
}