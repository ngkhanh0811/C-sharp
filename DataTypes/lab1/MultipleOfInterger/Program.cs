// See https://aka.ms/new-console-template for more information
using System;
class MultipleNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i<=9; i++)
        {
            Console.WriteLine($"{num} * {i} = {i*num}");   
        }
    }
}