using System;

class Student
{
    string _studentName = "Khanh";
    string _address = "VietNam";
    public virtual void PrintDetails()
    {
        Console.WriteLine("Student Name: " + _studentName);
        Console.WriteLine("Address: " + _address);
    }
}

class Grade : Student
{
    string _class = "Four";
    float _percent = 71.25F;
    public override void PrintDetails()
    {
        Console.WriteLine("Class: " + _class);
        Console.WriteLine("Percentage: " + _percent);
    }

    static void Main(string[] args)
    {
        Student objStu = new Student();
        Grade objGra = new Grade();
        objStu.PrintDetails();
        objGra.PrintDetails();
    }
}