using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        public string Book_Name { get; set; }
        public string Author_Name { get; set; }

        public Book(string bookname, string authorname)
        {
            Author_Name = authorname;
            Book_Name = bookname;
        }
        public void display()
        {
            Console.WriteLine($"Book: {Book_Name}, Author: {Author_Name}");
        }
    }

    class Book_Shelf
    {
        private Book[] books;

        public Book_Shelf()
        {
            books = new Book[5];

        }

        public void AddBook(Book book, int Index)
        {
            if (Index >= 0 && Index < books.Length)
            {
                books[Index] = book;
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }

        public void displayshelf()
        {
            for(int i = 0; i < books.Length; i++)
            {
                if (books[i] != null)
                {
                    Console.WriteLine($"Book{i + 1}:");
                    books[i].display();
                    Console.WriteLine();
                }
            }
        }
    }

    public class Day_Scholar : IStudent
{
    public int StudentId { get; set; }
    public string Name { get; set; }

    public void ShowDetails()
    {
        Console.WriteLine("Dayscholar Details:");
        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine($"Name: {Name}");
    }
}

    class test
    {
        static void Main(string[] args)
        {
            Book_Shelf shelf = new Book_Shelf();
            for (int i = 0; i < 5; i++)
            {
              
                Console.WriteLine("Enter the Book Name: ");
                string bookname = Console.ReadLine();

                Console.WriteLine("Enter Author Name: ");
                string authorname = Console.ReadLine();

                Book book = new Book(bookname, authorname);

                Console.Write($"Enter the index for book (Start from 0): ");
                int Index = int.Parse(Console.ReadLine());

                shelf.AddBook(book, Index);
            }
            Console.WriteLine("\n\nBooks on the shelf are: ");
            shelf.displayshelf();
            Console.ReadLine();

            //Program 2

            Console.WriteLine("Enter dimensions for Box 1");
            Console.Write("Length: ");
            double length1 = double.Parse(Console.ReadLine());
            Console.Write("Breadth: ");
            double breadth1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter dimensions for Box 2");
            Console.Write("Length: ");
            double length2 = double.Parse(Console.ReadLine());
            Console.Write("Breadth: ");
            double breadth2 = double.Parse(Console.ReadLine());

            Box box1 = new Box(length1, breadth1);
            Box box2 = new Box(length2, breadth2);

            Box box3 = Box.Add_Dimensions(box1, box2);

            box3.Display_Box();

            Console.ReadLine();
            

            //Program 3

            Console.WriteLine("Details for Part-Time Employee");
            Console.WriteLine("Enter Employee ID:");
            int empid = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name:");
            string empname = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary:");
            float salary = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Wage:");
            float wages = float.Parse(Console.ReadLine());

            PartTimeEmployee Parttime = new PartTimeEmployee(empid, empname, salary, wages);
            Parttime.Display_employee();
            Console.ReadLine();

            //Program 4

            Console.WriteLine("Enter details for Dayscholar");
           
            Console.Write("Student ID: ");
            int dayscholarId = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string dayscholarName = Console.ReadLine();

            IStudent dayscholar = new DayScholar { StudentId = dayscholarId, Name = dayscholarName };

            Console.WriteLine("\n\nEnter details for Resident");
           
            Console.Write("Student ID: ");
            int residentId = int.Parse(Console.ReadLine());
           
            Console.Write("Name: ");
            string residentName = Console.ReadLine();

            IStudent resident = new Resident { StudentId = residentId, Name = residentName };

            
            Console.WriteLine("\n\nDetails");
            Console.WriteLine("-------------------");
            dayscholar.ShowDetails();
            resident.ShowDetails();
            Console.Read();
        }
    }
    
}
