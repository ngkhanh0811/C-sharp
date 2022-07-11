using System;
using System.Collections.Generic;

class GenericDepartment<T>
{
    T[] item;
    public GenericDepartment(T[] val)
    {
        item = val;
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach(T value in item)
        {
            yield return value;
        }
    }
}
class GenericIterator
{
    static void Main(string[] args)
    {
        string[] departmentNames = { "Marketing", "Finance", "Technology", "Human Resource" };
        GenericDepartment<string> objGen = new GenericDepartment<string>(departmentNames);
        foreach (string val in objGen)
        {
            Console.Write(val + "\t");
        }
        int[] departmentID = { 101, 110, 210, 220 };
        GenericDepartment<int> objGenID = new GenericDepartment<int>(departmentID);
        Console.WriteLine();
        foreach (int val in objGenID)
        {
            Console.Write(val + "\t\t");
        }
        Console.WriteLine();
    }
}