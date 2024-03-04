
using System;

public class Customer
{
    private string Customer_id;
    private string Cust_Name;
    private int Age;
    private string Phone;
    private string City;

    public Customer()
    {
        Console.WriteLine("Constructor with no arguments ");

    }


    public Customer(string Customer_id, string Cust_Name, int Age, string Phone, string City)
    {
        this.Customer_id = Customer_id;
        this.Cust_Name = Cust_Name;
        this.Age = Age;
        this.Phone = Phone;
        this.City = City;


    }

    public void Display_Customer()
    {
        Console.WriteLine("Customer ID: " + Customer_id);
        Console.WriteLine("Name: " + Cust_Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Phone: " + Phone);
        Console.WriteLine("City: " + City);
    }

    ~Customer()
    {
        Console.WriteLine("Destructor");
    }
    public static void DisplayCustomerInfo(string Customer_id, string Cust_Name, int Age, string Phone, string City)
    {
        Console.WriteLine("Customer ID: " + Customer_id);
        Console.WriteLine("Name: " + Cust_Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Phone: " + Phone);
        Console.WriteLine("City: " + City);
        Console.Read();
    }



}
