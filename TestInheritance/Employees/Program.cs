using System;

class Employees
{
    int _empID = 1;
    string _empName = "Nguyen Khanh";
    int _age = 25;
    public void Display()
    {
        Console.WriteLine("Employee ID: " + _empID);
        Console.WriteLine("Employee name: " + _empName);
    }
}

class Department : Employees
{
    int _depId = 501;
    string _deptName = "Sales";
    new void Display()
    {
        base.Display();
        Console.WriteLine("Department ID: " + _depId);
        Console.WriteLine("Department name: "+ _deptName);
    }

    static void Main(string[] args)
    {
        Department objDepartment = new Department();
        objDepartment.Display();
    }
}