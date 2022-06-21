// See https://aka.ms/new-console-template for more information
using System;
class SortNumber
{
    public static void Main(string[] args)
    {
        int num1 = System.Int32.Parse(Console.ReadLine());
        int num2 = System.Int32.Parse(Console.ReadLine());
        int num3 = System.Int32.Parse(Console.ReadLine());

        Console.WriteLine("So lon nhat la: " + Math.Max(Math.Max(num1, num2), num3));
    }
}