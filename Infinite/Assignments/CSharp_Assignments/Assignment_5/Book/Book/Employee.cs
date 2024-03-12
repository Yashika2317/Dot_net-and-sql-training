using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Employee
{
    private int Emp_id;
    private string Emp_Name;
    private float Salary;

    public Employee(int empid, string empname,float salary)
    {
        Emp_id = empid;
        Emp_Name = empname;
        Salary = salary;

    }
    public virtual void Display_employee()
    {
        Console.WriteLine($"Employee ID: {Emp_id}");
        Console.WriteLine($"Employee Name: {Emp_Name}");
        Console.WriteLine($"Salary: {Salary}");
    }
}

class PartTimeEmployee : Employee
{
    public float Wages { get; set; }

    public PartTimeEmployee(int empid, string empname, float salary, float wages) : base(empid, empname, salary)
    {
        Wages = wages;

    }
    public override void Display_employee()
    {
        base.Display_employee();
        Console.WriteLine($"Wages: {Wages}");
    }
}

