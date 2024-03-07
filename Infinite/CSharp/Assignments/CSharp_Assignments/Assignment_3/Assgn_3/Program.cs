using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Assignment Question 1

namespace Assgn_3
{
    public class Name
    {

        private string First_Name;
        private string Last_Name;
        public Name(string FirstName, string LastName)
        {
            this.First_Name = FirstName;
            this.Last_Name = LastName;
        }
        public delegate void str(String FirstName,string LastName);
        public static void Display(String FirstName, string LastName)
        {
            Console.WriteLine(FirstName.ToUpper());
            Console.WriteLine(LastName.ToUpper());
        }

        public void CallDisplay()
        {
            str s1 = new str(Display);
            s1(this.First_Name, this.Last_Name);
        } 

        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name:");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            string LastName = Console.ReadLine();

            Name p = new Name(FirstName, LastName);
            p.CallDisplay();
            Console.ReadLine();

            //Main function for lettercound 2nd program


            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            Console.Write("Enter the letter to count: ");
            char letterToCount = Console.ReadKey().KeyChar;
            Console.WriteLine(); 

            LetterCounter counter = new LetterCounter();
            int count = counter.CountOccurrences(inputString, letterToCount);

            Console.WriteLine($"The letter '{letterToCount}' occurs {count} times in the string."); 

            //Main function for account.cs 3rd program

            
            Console.WriteLine("Enter Account Number:");
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
            
            //Main method for 4th program

            Console.WriteLine("Enter marks:");
            int marks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter fees:");
            double fees = Convert.ToDouble(Console.ReadLine());

            Scholarship scholarship = new Scholarship();
            double Scholarship_Amount = scholarship.Merit(marks, fees);

            Console.WriteLine($"Scholarship amount: {Scholarship_Amount}");
            Console.ReadLine();
            
            //Main mwthod for 5th program
            Doctor doctor = new Doctor();

            Console.WriteLine("Enter Registration Number:");
            int regnNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Fees:");
            double feesCharged = Convert.ToDouble(Console.ReadLine());

            doctor.set(regnNo, name, feesCharged);
            doctor.Doctor_Display();

            Console.Read();
        }
    }
    
    
}
