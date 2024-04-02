using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();

            Employees.Add(new Employee(1001, "Malcolm", "Daruwalla", "Manager", new DateTime(1984, 11, 16), new DateTime(2011, 6, 8), "Mumbai"));
            Employees.Add(new Employee(1002, "Asdin", "Dhalla", "AsstManager", new DateTime(1984, 8, 20), new DateTime(2012, 7, 7), "Mumbai"));
            Employees.Add(new Employee(1003, "Madhavi", "Oza", "Consultant", new DateTime(1987, 11, 14), new DateTime(2015, 4, 12), "Pune"));
            Employees.Add(new Employee(1004, "Saba", "Shaikh", "SE", new DateTime(1990, 6, 3), new DateTime(2016, 2, 2), "Pune"));
            Employees.Add(new Employee(1005, "Nazia", "Shaikh", "SE", new DateTime(1991, 3, 8), new DateTime(2016, 2, 2), "Mumbai"));
            Employees.Add(new Employee(1006, "Amit", "Pathak", "Consultant", new DateTime(1989, 11, 7), new DateTime(2014, 8, 8), "Chennai"));
            Employees.Add(new Employee(1007, "Vijay", "Natrajan", "Consultant", new DateTime(1989, 12, 2), new DateTime(2015, 6, 1), "Mumbai"));
            Employees.Add(new Employee(1008, "Rahul", "Dubey", "Associate", new DateTime(1993, 11, 11), new DateTime(2014, 11, 6), "Chennai"));
            Employees.Add(new Employee(1009, "Suresh", "Mistry", "Associate", new DateTime(1992, 8, 12), new DateTime(2014, 12, 3), "Chennai"));
            Employees.Add(new Employee(1010, "Sumit", "Shah", "Manager", new DateTime(1991, 4, 12), new DateTime(2016, 1, 2), "Pune"));

            
            // 1. Display a list of all the employees who have joined before 1/1/2015

            var Emp2015 = Employees.Where(emp => emp.DOJ < new DateTime(2015, 1, 1));
            Console.WriteLine("Employees joined before 1/1/2015:");
            Console.WriteLine("-----------------------------------------------");
            DisplayEmp(Emp2015);


            // 2. Display a list of all the employees whose date of birth is after 1/1/1990

            var Emp1990 = Employees.Where(emp => emp.DOB > new DateTime(1990, 1, 1));
            Console.WriteLine("\nEmployees whose date of birth is after 1/1/1990:");
            Console.WriteLine("-----------------------------------------------");

            DisplayEmp(Emp1990);


            // 3. Display a list of all the employees whose designation is Consultant and Associate

            var Designation = Employees.Where(emp => emp.Title == "Consultant" || emp.Title == "Associate");
            Console.WriteLine("\nEmployees with designation Consultant or Associate:");
            Console.WriteLine("-----------------------------------------------");

            DisplayEmp(Designation);


            // 4. Display total number of employees

            Console.WriteLine($"\nTotal number of employees: {Employees.Count}");


            // 5. Display total number of employees belonging to “Chennai”

            var chennaiCount = Employees.Count(emp => emp.City == "Chennai");
            Console.WriteLine($"\nTotal number of employees in Chennai: {chennaiCount}");


            // 6. Display highest employee id from the list

            var EmpId = Employees.Max(emp => emp.EmployeeID);
            Console.WriteLine($"\nHighest employee ID: {EmpId}");


            // 7. Display total number of employees who have joined after 1/1/2015

            var joined2015Count = Employees.Count(emp => emp.DOJ > new DateTime(2015, 1, 1));
            Console.WriteLine($"\nTotal number of employees joined after 1/1/2015: {joined2015Count}");


            // 8. Display total number of employees whose designation is not “Associate”

            var nonAssociateCount = Employees.Count(emp => emp.Title != "Associate");
            Console.WriteLine($"\nTotal number of employees with designation not Associate: {nonAssociateCount}");



            // 9. Display total number of employees based on City

            var empCity = Employees.GroupBy(emp => emp.City).Select(g => new { City = g.Key, Count = g.Count() });
            Console.WriteLine("\nTotal number of employees based on City:");
            Console.WriteLine("-----------------------------------------------");

            foreach (var cityGroup in empCity)
            {
                Console.WriteLine($"{cityGroup.City}: {cityGroup.Count}");
            }


            // 10. Display total number of employees based on city and title


            var NoEmps = Employees.GroupBy(emp => new { emp.City, emp.Title }).Select(g => new { City = g.Key.City, Title = g.Key.Title, Count = g.Count() });
            Console.WriteLine("\nTotal number of employees based on City and Title:");
            Console.WriteLine("------------------------------------------------");

            foreach (var v in NoEmps)
            {
                Console.WriteLine($"{v.City}, {v.Title}: {v.Count}");
            }


            // 11. Display total number of employees who are youngest in the list


            var youngestEmployees = Employees.Where(emp => emp.DOB == Employees.Min(e => e.DOB));
            Console.WriteLine("\nTotal number of employees who are youngest in the list:");
            Console.WriteLine(youngestEmployees.Count());

            Console.ReadLine();
        }

        static void DisplayEmp(IEnumerable<Employee> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.EmployeeID}\t{emp.FirstName}\t{emp.LastName}\t{emp.Title}\t{emp.DOB.ToShortDateString()}\t{emp.DOJ.ToShortDateString()}\t{emp.City}");
            }
        }
    }
    
}
