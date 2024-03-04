using System;

public class Accounts
{
    private string Account_Number;
    private string Customer_Name;
    private string Account_Type;
    private char Transaction_Type;
    private double Amount;
    private double Balance;

    public Accounts(string Account_Number, string Customer_Name, string Account_Type, char Transaction_Type, double Amount)
    {
        this.Account_Number = Account_Number;
        this.Customer_Name = Customer_Name;
        this.Account_Type = Account_Type;
        this.Transaction_Type = Transaction_Type;
        this.Amount = Amount;
        this.Balance = 10000;
    }

    public void Credit(double Amount)
    {
        Balance += Amount;
    }

    public void Debit(double Amount)
    {
        if (Amount > Balance)
        {
            Console.WriteLine("Insufficient Balance.");
        }
        else
        {
            Balance -= Amount;
        }
    }

    public void UpdateBalance()
    {
        if (Transaction_Type == 'D'|| Transaction_Type == 'd')
        {
            Credit(Amount);
        }
        else if (Transaction_Type == 'W'|| Transaction_Type == 'w')
        {
            Debit(Amount);
        }
        else
        {
            Console.WriteLine("Invalid transaction.");
        }
        Console.Read();
    }

    public void ShowData()
    {
        Console.WriteLine("Account Number: " + Account_Number);
        Console.WriteLine("Customer Name: " + Customer_Name);
        Console.WriteLine("Account Type: " + Account_Type);
        Console.WriteLine("Transaction Type: " + Transaction_Type);
        Console.WriteLine("Amount: " + Amount);
        Console.WriteLine("Balance: " + Balance);
        Console.Read();
    }

    static void Main(string[] args)
    {
        /*Console.WriteLine("Enter Account Number:");
        string Account_Number = Console.ReadLine();

        Console.WriteLine("Enter Customer Name:");
        string Customer_Name = Console.ReadLine();

        Console.WriteLine("Enter Account Type:");
        string Account_Type = Console.ReadLine();

        Console.WriteLine("Enter Transaction Type (D/W):");
        char Transaction_Type = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter Amount:");
        double Amount = Convert.ToDouble(Console.ReadLine());

        Accounts account = new Accounts(Account_Number, Customer_Name, Account_Type, Transaction_Type, Amount);
        account.UpdateBalance();
        account.ShowData();
        Console.ReadLine(); 

     

        //Main function for salesetails.cs

        Console.WriteLine("Enter Sales No:");
        int Sales_No = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Product No:");
        int Product_No = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Price:");
        double Price = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Quantity:");
        int Quantity = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Date of Sale (yyyy-MM-dd):");
        DateTime Date_of_Sale = DateTime.Parse(Console.ReadLine());

        Saledetails sale = new Saledetails(Sales_No, Product_No, Price, Date_of_Sale, Quantity);
        sale.ShowData();
        Console.ReadLine();


        // Main fuction for Student.cs

        Console.WriteLine("Enter Roll No:");
        int Roll_No = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Name:");
        string Name = Console.ReadLine();

        Console.WriteLine("Enter Class:");
        string Class = Console.ReadLine();

        Console.WriteLine("Enter Semester:");
        string Semester = Console.ReadLine();

        Console.WriteLine("Enter Branch:");
        string Branch = Console.ReadLine();
        Student student = new Student(Roll_No, Name, Class, Semester, Branch);
        student.GetMarks();
        Console.WriteLine();
        student.DisplayData();
        student.DisplayResult();
        Console.ReadLine(); */


       //Main function for customer.cs


        Console.WriteLine("Enter Customer ID:");
        string Custome_id = Console.ReadLine();

        Console.WriteLine("Enter Name:");
        string Cust_Name = Console.ReadLine();

        Console.WriteLine("Enter Age:");
        int Age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Phone:");
        string Phone = Console.ReadLine();

        Console.WriteLine("Enter City:");
        string City = Console.ReadLine();

    
        Customer customer1 = new Customer(Custome_id, Cust_Name, Age, Phone, City);
        customer1.Display_Customer();

        Console.WriteLine();

        Customer customer2 = new Customer();
        customer2.Display_Customer();

        Console.WriteLine();

        Customer.DisplayCustomerInfo(Custome_id, Cust_Name, Age, Phone, City);

        Console.Read();
        

       
        
    }
}

