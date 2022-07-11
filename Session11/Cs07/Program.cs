﻿using System;

delegate T DelMath<T>(T val);
class Numbers
{
    static int NumberType(int num)
    {
        if (num % 2 == 0)
        {
            return num;
        }
        else
        {
            return (0);
        }
    }
    static float NumberType(float num)
    {
        return num % 2.5F;
    }
    public static void Main(string[] args)
        {
            DelMath<int> objDel = NumberType;
            DelMath<float> objDel2 = NumberType;
            Console.WriteLine(objDel(10));
            Console.WriteLine(objDel2(108.756F));
        }
}