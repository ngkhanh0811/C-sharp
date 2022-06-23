using System;

int num = 1;
Console.WriteLine("Even number");
do
{
    if ((num % 2) == 0)
    {
        Console.WriteLine(num);
    }
    num = num + 1;
} while (num <= 11);