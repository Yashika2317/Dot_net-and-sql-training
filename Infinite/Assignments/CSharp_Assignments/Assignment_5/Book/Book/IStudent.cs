using System;
public interface IStudent
{
    int StudentId { get; set; }
    string Name { get; set; }

    void ShowDetails();
}

public class DayScholar : IStudent
{
    public int StudentId { get; set; }
    public string Name { get; set; }

    public void ShowDetails()
    {
        Console.WriteLine("\nDayscholar Details");
        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine($"Name: {Name}");
    }
}

public class Resident : IStudent
{
    public int StudentId { get; set; }
    public string Name { get; set; }

    public void ShowDetails()
    {
        Console.WriteLine("\nResident Details:");
        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine($"Name: {Name}");
    }
}



