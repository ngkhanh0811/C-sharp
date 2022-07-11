using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

class ReadOnly
{
    static void Main(string[] args)
    {
        List<string> objList = new List<string>();
        objList.Add("Francis");
        objList.Add("Janes");
        objList.Add("Baptisa");
        objList.Add("Charlie");
        ReadOnlyCollection<string> objReadOnly = new ReadOnlyCollection<string>(objList);
        Console.WriteLine("Value stored in the read only collection");
        foreach (string str in objReadOnly)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine();
        Console.WriteLine("Total number of elements in the read only collection: " + objList.Count);

        if (objList.Contains("Francis"))
        {
            objList.Insert(2, "Peter");
        }
        Console.WriteLine("\nValues stored in the list after modification");
        foreach(string str in objReadOnly)
        {
            Console.WriteLine(str);
        }
        string[] array = new string[objList.Count*2];
        objReadOnly.CopyTo(array, 5);
        Console.WriteLine("\nTotal number of values that can be stored in the new array: " + array.Length);
        Console.WriteLine("Values in the new array");
        foreach(string str in array)
        {
            if(str == null)
            {
                Console.WriteLine("Null!");
            } else
            {
                Console.WriteLine(str);
            }
        }
    }
}