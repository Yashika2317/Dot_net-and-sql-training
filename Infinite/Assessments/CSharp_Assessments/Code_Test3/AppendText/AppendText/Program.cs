using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendText
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter text to append to the file:");

            string text = Console.ReadLine();
            string filePath = "Append.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(text);
                }

                Console.WriteLine("Text appended successfully to the file!");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while appending to the file:");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();


            //Program 2

            CalculatorDelegate addition = Calculator.Addition;
            CalculatorDelegate subtraction = Calculator.Subtraction;
            CalculatorDelegate multiplication = Calculator.Multiplication;

            Console.Write("Enter the first Number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second Number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = addition(num1, num2);
            Console.WriteLine($"The Sum is: {sum}");

            int difference = subtraction(num1, num2);
            Console.WriteLine($"The Difference is: {difference}");

            int product = multiplication(num1, num2);
            Console.WriteLine($"The Product is: {product}");

            Console.ReadLine();
     

            //Program 3

            List<Employee> empList = new List<Employee>
            {
                new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = DateTime.Parse("11/16/1984"), DOJ = DateTime.Parse("06/08/2011"), City = "Mumbai" },
                new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = DateTime.Parse("08/20/1984"), DOJ = DateTime.Parse("07/07/2012"), City = "Mumbai" },
                new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = DateTime.Parse("11/14/1987"), DOJ = DateTime.Parse("04/14/2015"), City = "Pune" },
                new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = DateTime.Parse("06/03/1990"), DOJ = DateTime.Parse("02/02/2016"), City = "Pune" },
                new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = DateTime.Parse("03/08/1991"), DOJ = DateTime.Parse("02/02/2016"), City = "Mumbai" },
                new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = DateTime.Parse("11/07/1989"), DOJ = DateTime.Parse("08/08/2014"), City = "Chennai" },
                new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = DateTime.Parse("12/02/1989"), DOJ = DateTime.Parse("01/06/2015"), City = "Mumbai" },
                new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = DateTime.Parse("11/11/1993"), DOJ = DateTime.Parse("11/06/2014"), City = "Chennai" },
                new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = DateTime.Parse("08/12/1992"), DOJ = DateTime.Parse("12/03/2014"), City = "Chennai" },
                new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = DateTime.Parse("04/12/1991"), DOJ = DateTime.Parse("01/02/2016"), City = "Pune" }
            };

            Console.WriteLine("Details of all employees:\n");
            foreach (var emp in empList)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, FirstName: {emp.FirstName}, LastName: {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
            }

            var nonMumbaiEmployees = empList.Where(emp => emp.City != "Mumbai");
            Console.WriteLine("\nDetails of employees not in Mumbai:\n");
            foreach (var emp in nonMumbaiEmployees)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, FirstName: {emp.FirstName}, LastName: {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
            }

            var asstManagers = empList.Where(emp => emp.Title == "AsstManager");
            Console.WriteLine("\nDetails of Assistant Managers:\n");
            foreach (var emp in asstManagers)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, FirstName: {emp.FirstName}, LastName: {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
            }

            var lastNameStartsWithS = empList.Where(emp => emp.LastName.StartsWith("S"));
            Console.WriteLine("\nDetails of employees whose Last Name starts with 'S':\n");
            foreach (var emp in lastNameStartsWithS)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, FirstName: {emp.FirstName}, LastName: {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
            }
            Console.ReadLine();
        }
    }

}
