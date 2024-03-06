using System;

public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
    }
}

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
            throw new InsufficientBalanceException("Insufficient Balance.");
        }
        else
        {
            Balance -= Amount;
        }
    }

    public void UpdateBalance()
    {
        if (Transaction_Type == 'D' || Transaction_Type == 'd')
        {
            Credit(Amount);
        }
        else if (Transaction_Type == 'W' || Transaction_Type == 'w')
        {
            try
            {
                Debit(Amount);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine(ex.Message);
            }
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

}

   