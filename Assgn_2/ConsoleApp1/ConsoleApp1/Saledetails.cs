using System;

public class Saledetails
{
    private int Sales_No;
    private int Product_No;
    private double Price;
    private DateTime Date_of_Sale;
    private int Quantity;
    private double Total_Amount;


    public Saledetails(int Sales_No, int Product_No, double Price, DateTime Date_of_Sale, int Quantity)
    {
        this.Sales_No = Sales_No;
        this.Product_No = Product_No;
        this.Price = Price;
        this.Date_of_Sale = Date_of_Sale;
        this.Quantity = Quantity;
        Sales();
    }

    
    private void Sales()
    {
        Total_Amount = Quantity * Price;
    }

   
    public void ShowData()
    {
        Console.WriteLine("Sales No: " + Sales_No);
        Console.WriteLine("Product No: " + Product_No);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Date of Sale: " + Date_of_Sale);
        Console.WriteLine("Quantity: " + Quantity);
        Console.WriteLine("Total Amount: " + Total_Amount);
    }

    
   
}
