// See https://aka.ms/new-console-template for more information
using System;
class Ex5
{
    static void Main(string[] args)
    {
        double num=1;
        int x = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= x; i++)
        {
            Console.WriteLine(num*=i);
        }
    }
}