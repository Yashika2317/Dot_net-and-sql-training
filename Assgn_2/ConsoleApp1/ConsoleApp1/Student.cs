using System;

public class Student
{
    private int Roll_No;
    private string Name;
    private string Class;
    private string Semester;
    private string Branch;
    private int[] marks = new int[5];


    public Student(int Roll_No, string Name, string Class, string Semester, string Branch)
    {
        this.Roll_No = Roll_No;
        this.Name = Name;
        this.Class = Class;
        this.Semester = Semester;
        this.Branch = Branch;
    }

   
    public void GetMarks()
    {
        Console.WriteLine("Enter marks for 5 subjects:");
        for (int i = 0; i < marks.Length; i++)
        {
            Console.Write("Enter marks for Subject " + (i + 1) + ": ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }
    }


    public void DisplayData()
    {
        Console.WriteLine("Roll No: " + Roll_No);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Class: " + Class);
        Console.WriteLine("Semester: " + Semester);
        Console.WriteLine("Branch: " + Branch);
        Console.WriteLine("Marks:");
        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine("Subject " + (i + 1) + ": " + marks[i]);
        }
    }

   
    public void DisplayResult()
    {
        double averAge = CalculateAverAge();
        bool hasFailed = false;

   
        foreach (int mark in marks)
        {
            if (mark < 35)
            {
                hasFailed = true;
                
            }
        }

        if (!hasFailed && averAge < 50)
        {
            hasFailed = true;
        }

      
        if (hasFailed)
        {
            Console.WriteLine("Result: Failed");
        }
        else
        {
            Console.WriteLine("Result: Passed");
        }
    }

    private double CalculateAverAge()
    {
        double sum = 0;
        foreach (int mark in marks)
        {
            sum += mark;
        }
        return sum / marks.Length;
    }

   
}
