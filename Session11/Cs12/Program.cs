using System;

class NamedIterators
{
    string[] cars = { "Ferrari", "BMW", "Mercesdes", "Toyota" };
    public IEnumerable GetCarNames()
    {
        for(int i=0; i < cars.Length; i++)
        {
            yield return cars[i];
        }
    }

    static void Main(string[] args)
    {
        NamedIterators s = new NamedIterators();
        foreach (string str in s.GetCarNames())
        {
            Console.WriteLine(str);
        }
    }
}