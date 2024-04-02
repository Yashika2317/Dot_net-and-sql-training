using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }

        // Constructor
        public Employee(int id, string firstName, string lastName, string title, DateTime dob, DateTime doj, string city)
        {
            EmployeeID = id;
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            DOB = dob;
            DOJ = doj;
            City = city;
        }
    }
}
