using System;


namespace Code_Test2
{
    using System;
    abstract class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public double Grade { get; set; }
        public Student(string name, int studentId, double grade)
        {
            this.Name = name;
            this.StudentId = studentId;
            this.Grade = grade;
        }
        public abstract bool IsPassed(double grade);
    }
    class Undergraduate : Student
    {
        public Undergraduate(string name, int studentId, double grade) : base(name, studentId, grade)
        {
        }

        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }

    class Graduate : Student
    {
        public Graduate(string name, int studentId, double grade) : base(name, studentId, grade)
        {
        }

        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Main function for program 1
            Console.WriteLine("Enter details for Undergrad:");
            Console.Write("Name: ");
            string undergradName = Console.ReadLine();

            Console.Write("Student ID: ");
            int undergradId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Grade: ");
            double undergradGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter details for Grad:");
            Console.Write("Name: ");
            string gradName = Console.ReadLine();

            Console.Write("Student ID: ");
            int gradId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Grade: ");
            double gradGrade = Convert.ToDouble(Console.ReadLine());

            Undergraduate undergrad = new Undergraduate(undergradName, undergradId, undergradGrade);
            Graduate grad = new Graduate(gradName, gradId, gradGrade);

            Console.WriteLine("\nUndergrad");
            Console.WriteLine("Name: " + undergrad.Name);
            Console.WriteLine("Student ID: " + undergrad.StudentId);
            Console.WriteLine("Grade: " + undergrad.Grade);
            Console.WriteLine("Passed: " + undergrad.IsPassed(undergrad.Grade));

            Console.WriteLine("\nGrad");
            Console.WriteLine("Name: " + grad.Name);
            Console.WriteLine("Student ID: " + grad.StudentId);
            Console.WriteLine("Grade: " + grad.Grade);
            Console.WriteLine("Passed: " + grad.IsPassed(grad.Grade));
            Console.ReadLine();
            
            //Main function for Program 2

            Products[] product = new Products[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter details for Product {i + 1}:");
                Console.Write("Product ID: ");
                int productId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Product Name: ");
                string productName = Console.ReadLine();

                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                product[i] = new Products(productId, productName, price);
            }

            for (int i = 0; i < product.Length - 1; i++)
            {
                for (int j = 0; j < product.Length - 1 - i; j++)
                {
                    if (product[j].Price > product[j + 1].Price)
                    {
                        Products temp = product[j];
                        product[j] = product[j + 1];
                        product[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nFinal products list:");
            foreach (Products products in product)
            {
                Console.WriteLine($"Products ID: {products.Product_id}, Products Name: {products.Product_Name}, Price: {products.Price}");
            }

            Console.Read();
        }
       
    }
}

