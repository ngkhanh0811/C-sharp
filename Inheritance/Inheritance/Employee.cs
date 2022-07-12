using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Employee
    {
        private string empName;
        private int empId;
        private double empSalary;
        private static int employeeCount = 1;

        public string Name
        {
            get
            {
                return empName;
            }
            set
            {
                empName = value;
            }
        }

        public int ID
        {
            get { return empId; }
            set { empId = value; }
        }

        public double Salary
        {
            get { return empSalary; }
            set { empSalary = value; }
        }
        public Employee(string name, double salary)
        {
            this.Name = name;
            this.Salary = salary;
            this.ID = employeeCount++;
        }
        public double getSalary()
        {
            return this.Salary;
        }
        public string getName()
        {
            return this.Name;
        }
        public int getID()
        {
            return this.ID;
        }
        public string toString()
        {
            return this.ID + " " + this.Name;
        }
        public virtual string employeeStatus()
        {
            return toString() + "is in the company's system";
        }
    }

    class TechnicalEmployee : Employee
    {
        public int successfulCheckIns = 5;
        public TechnicalEmployee(string name) : base(name, 75000)
        {

        }
        public override string employeeStatus()
        {
            return this.ToString() + "has" + this.successfulCheckIns + "successful check ins";
        }
    }

    class BusinessEmployee : Employee
    {
        public double bonusBudget = 1000;
        public BusinessEmployee(string name) : base(name, 50000)
        {

        }
        public override string employeeStatus()
        {
            return this.toString() + "with a budget of " + this.bonusBudget;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            var employee1 = new Employee("Libby", 200);
            var employee2 = new TechnicalEmployee("Zaynah");
            var employee3 = new BusinessEmployee("Winter");

            Console.WriteLine(employee1.employeeStatus() + "..." + employee2.employeeStatus() + "..." + employee3.employeeStatus());
        }
    }
}
