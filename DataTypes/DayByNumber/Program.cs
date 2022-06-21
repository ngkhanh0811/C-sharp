// See https://aka.ms/new-console-template for more information
using System;
class DayByNumber
{
    static void Main(string[] args)
    {
        int num = System.Int32.Parse(Console.ReadLine());
        switch (num)
        {
            case 1: Console.WriteLine("Monday");
                break;
            case 2: Console.WriteLine("Tuesday");
                break;
            case 3: Console.WriteLine("Wednesday");
                break;
            case 4: Console.WriteLine("Thursday");
                break;  
            case 5: Console.WriteLine("Friday");
                break;
            case 6: Console.WriteLine("Saturday");
                break;
            case 7: Console.WriteLine("Sunday");
                break;
            default: Console.WriteLine("Undefined!");
                break;
        }
    }
}