using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();

            Employees.Add(new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" });
            Employees.Add(new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" });
            Employees.Add(new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" });
            Employees.Add(new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" });
            Employees.Add(new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" });
            Employees.Add(new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" });
            Employees.Add(new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" });
            Employees.Add(new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" });
            Employees.Add(new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" });
            Employees.Add(new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" });


            // 1. Display a list of all the employees who have joined before 1/1/2015
            Console.WriteLine("Employees joined before 1/1/2015:");
            Console.WriteLine("---------------------------------------------------");

            foreach (var emp in Employees)
            {
                if (emp.DOJ < new DateTime(2015, 1, 1))
                {
                    Console.WriteLine($"{emp.FirstName} {emp.DOJ}");
                }
            }

            Console.ReadLine();

            // 2. Display a list of all the employees whose date of birth is after 1/1/1990
            Console.WriteLine("Employees born after 1/1/1990:");
            Console.WriteLine("---------------------------------------------------");

            foreach (var emp in Employees)
            {
                if (emp.DOB > new DateTime(1990, 1, 1))
                {
                    Console.WriteLine($"{emp.FirstName} {emp.LastName} {emp.DOB}");
                }
            }
            Console.ReadLine();


            // 3. Display a list of all the employees whose designation is Consultant and Associate
            Console.WriteLine("Employees with designation Consultant and Associate:");
            Console.WriteLine("---------------------------------------------------");

            foreach (var emp in Employees)
            {
                if (emp.Title == "Consultant" || emp.Title == "Associate")
                {
                    Console.WriteLine($"{emp.FirstName} {emp.LastName} {emp.Title}");
                }
            }
            Console.ReadLine();

            // 4. Display total number of employees
            Console.WriteLine($"Total number of employees: {Employees.Count}");
            Console.WriteLine();
            Console.ReadLine();



            // 5. Display total number of employees belonging to “Chennai”
            int countChennai = 0;
            foreach (var emp in Employees)
            {
                if (emp.City == "Chennai")
                {
                    countChennai++;
                }
            }
            Console.WriteLine($"Total number of employees belonging to Chennai: {countChennai}");
            Console.WriteLine();
            Console.ReadLine();


            // 6. Display highest employee id from the list
            int ID = int.MinValue;
            foreach (var emp in Employees)
            {
                if (emp.EmployeeID > ID)
                {
                    ID = emp.EmployeeID;
                }
            }
            Console.WriteLine($"Highest employee ID: {ID}");
            Console.WriteLine();
            Console.ReadLine();


            // 7. Display total number of employees who have joined after 1/1/2015
            int countEmp = 0;
            foreach (var emp in Employees)
            {
                if (emp.DOJ > new DateTime(2015, 1, 1))
                {
                    countEmp++;
                }
            }
            Console.WriteLine($"Total number of employees joined after 1/1/2015: {countEmp}");
            Console.WriteLine();
            Console.ReadLine();


            // 8. Display total number of employees whose designation is not “Associate”
            int countNotAssociate = 0;
            foreach (var emp in Employees)
            {
                if (emp.Title != "Associate")
                {
                    countNotAssociate++;
                }
            }
            Console.WriteLine($"Total number of employees whose designation is not Associate: {countNotAssociate}");
            Console.WriteLine();
            Console.ReadLine();



            // 9. Display total number of employees based on City
            Console.WriteLine("Total number of employees based on City:");
            Console.WriteLine("---------------------------------------------------");

            var distinctCities = Employees.Select(e => e.City).Distinct();
            foreach (var city in distinctCities)
            {
                int count = Employees.Count(e => e.City == city);
                Console.WriteLine($"{city}: {count}");
            }
            Console.WriteLine();
            Console.ReadLine();


            // 10. Display total number of employee based on city and title
            Console.WriteLine("Total number of employees based on City and Title:");
            Console.WriteLine("---------------------------------------------------");
            var distinctCitiesAndTitles = Employees.Select(e => new { City = e.City, Title = e.Title }).Distinct();
            foreach (var item in distinctCitiesAndTitles)
            {
                int count = Employees.Count(e => e.City == item.City && e.Title == item.Title);
                Console.WriteLine($"{item.City} {item.Title}: {count}");
            }
            Console.WriteLine();
            Console.ReadLine();



            // 11. Display total number of employee who is youngest in the list
            DateTime youngestEmp = Employees.Min(emp => emp.DOB);

            int countYoungestEmp = Employees.Count(emp => (emp.DOB) == youngestEmp);

            Console.WriteLine($"Total number of employees who are youngest in the list: {countYoungestEmp}");
            Console.WriteLine();
            Console.ReadLine();


        }

    }
    
}
