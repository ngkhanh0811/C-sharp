// See https://aka.ms/new-console-template for more information
using System;
class Information
{
    static void Main(string[] args)
    {
        string name;
        string address;
        string phone;
        var i1 = new { name = "Khanh", address = "Ha Noi", phone = "0987720543" };
        Console.WriteLine(i1);
    }
}