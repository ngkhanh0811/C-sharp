using System;

class People
{
    string name = "Nguyen Khanh";
    string date = "08/11/2003";
    public void people()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Date of birth: " + date);
    }
}

class Student : People
{
    int point = 100;
    public void student()
    {
        Console.WriteLine("Point: " + point);
    }
}

class Staff : People
{
    int salary = 2000;
    public void staff()
    {
        Console.WriteLine("Salary: " + salary);
    }
}

class Test
{
    public static void Main(string[] args)
    {
        Student objStudent = new Student();
        objStudent.people();
        objStudent.student();

        Staff objStaff = new Staff();
        objStaff.staff();
    }
}