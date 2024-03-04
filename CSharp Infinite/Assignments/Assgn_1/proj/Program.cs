using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_questions
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b;
            Console.WriteLine("Input 1st number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input 2nd number: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
                Console.WriteLine("{0} and {1} are equal.\n", a, b);
            else
                Console.WriteLine("{0} and {1} are not equal.\n", a, b);
            Console.ReadLine();

            Program program = new Program();
            program.pos_neg();
            program.calculation();
            program.table();
            program.triple_sum();
            program.arrays();
            program.marks();
            program.two_arrays();
            program.str_len();
            program.reverse();
            program.str_equal();

        }

        public void pos_neg()
        {
            Console.WriteLine("Program to check if a number is positive or negative");
            int num;
            Console.WriteLine("Enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("{0} is a positive number", num);
            else
                Console.WriteLine("{0} is a negative number", num);
            Console.ReadLine();
        }

        public void calculation()
        {
            int n1, n2;
            char operation;
            Console.WriteLine("Enter 1st number: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter operation: ");
            operation = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter 2nd number: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (operation == '+')
                Console.WriteLine("{0} + {1} = {2}", n1, n2, n1 + n2);
            else if (operation == '-')
                Console.WriteLine("{0} - {1} = {2}", n1, n2, n1 - n2);
            else if (operation == '/')
                Console.WriteLine("{0} / {1} = {2}", n1, n2, n1 / n2);
            else if (operation == '*')
                Console.WriteLine("{0} * {1} = {2}", n1, n2, n1 * n2);
            else
                Console.WriteLine("Invalid");
            Console.ReadLine();

        }

        public void table()
        {
            int j, n;

            Console.WriteLine("Input the number: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (j = 1; j <= 10; j++)
            {
                Console.WriteLine("{0} X {1} = {2} \n", n, j, n * j);
            }
            Console.ReadLine();

        }

        public void triple_sum()
        {
            int x, y;
            int z = 3;
            Console.WriteLine("Enter 1st number:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number:");
            y = Convert.ToInt32(Console.ReadLine());

            if (x == y)
                Console.WriteLine("{0} +{1} = {2} *{3} = {4}", x, y, x + y, z, (x + y) * z);
            else
                Console.WriteLine("{0}+{1} = {2}", x, y, x + y);
            Console.ReadLine();
        }

        public static void days()
        {
            char day;
            Console.WriteLine("Enter the day: ");
            day = Convert.ToChar(Console.ReadLine());

            switch (day)
            {
                case '1':
                    Console.WriteLine("Monday");
                    break;
                case '2':
                    Console.WriteLine("Tuesday");
                    break;
                case '3':
                    Console.WriteLine("Wednesday");
                    break;
                case '4':
                    Console.WriteLine("Thursday");
                    break;
                case '5':
                    Console.WriteLine("Friday");
                    break;

                case '6':
                    Console.WriteLine("Saturday");
                    break;
                case '7':
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;



            }
            Console.ReadLine();

        }

        public void arrays()
        {
            int[] arr1 = new int[100];
            int i, mx, mn, n, sum = 0;
            float avg = 0.0F;


            Console.Write("Input number of elements in array :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());

            }
            mx = arr1[0];
            mn = arr1[0];

            for (i = 0; i < n; i++)
            {
                if (arr1[i] > mx)
                {
                    mx = arr1[i];
                }

                if (arr1[i] < mn)
                {
                    mn = arr1[i];
                }
            }

            Console.WriteLine("Maximum element is : {0}\n", mx);
            Console.WriteLine("Minimum element is : {0}\n", mn);
            for (i = 0; i < arr1.Length; i++)
            {
                sum += arr1[i];
            }

            avg = (float)sum / arr1.Length;

            Console.WriteLine("Average of Array elements: " + avg);

            Console.Read();

        }

        public void marks()
        {
            int[] mark = new int[10];
            int i, sum = 0, max, min;
            float average = 0.0F;
            Console.WriteLine("Input {0} data in the array :\n");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("number - {0} : ", i);
                mark[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (i = 0; i < mark.Length; i++)
            {
                sum += mark[i];
            }
            Console.WriteLine("The sum is: " + sum);
            for (i = 0; i < mark.Length; i++)
            {
                sum += mark[i];
            }

            average = (float)sum / mark.Length;

            Console.WriteLine("Average of Array: " + average);

            Array.Sort(mark);
            Console.WriteLine("Array in Ascending order");
            foreach (int num in mark)
            {
                Console.WriteLine(num + " ");
            }

            Array.Reverse(mark);
            Console.WriteLine("Array in descending order");
            foreach (int num in mark)
            {
                Console.WriteLine(num + " ");

            }

            max = mark[0];
            min = mark[0];


            for (i = 1; i < 10; i++)
            {
                if (mark[i] > max)
                {
                    max = mark[i];
                }

                if (mark[i] < min)
                {
                    min = mark[i];
                }
            }


            Console.WriteLine("Maximum element is : {0}\n", max);
            Console.WriteLine("Minimum element is : {0}\n", min);
            Console.ReadLine();



        }

        public void two_arrays()
        {
            int[] arr_one = { 1, 2, 3 };
            int n = arr_one.Length;
            int i;
            int[] arr_two = new int[n];

            for (i = 0; i < n; i++)
            {
                arr_two[i] = arr_one[i];
            }
            Console.Write("\n 1st Array:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr_one[i]);
            }


            Console.Write("\n 2nd Array:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr_two[i]);
            }
            Console.Read();

        }

        public void str_len()
        {
            string str;
            int length = 0;
            Console.Write("Input the string: ");
            str = Console.ReadLine();
            foreach (char chr in str)
            {
                length += 1;
            }
            Console.Write("Length of the string is: {0}", length);
            Console.Read();
        }

        public void reverse()
        {
            string str = "", reverse = "";
            int Length = 0;

            Console.WriteLine("Enter the Word: ");
            str = Console.ReadLine();

            Length = str.Length - 1;

            while (Length >= 0)
            {
                reverse = reverse + str[Length];
                Length--;
            }


            Console.WriteLine("Reverse word is {0}", reverse);
            Console.ReadLine();
        }

        public void str_equal()
        {
            string str1 = "", str2 = "";

            Console.WriteLine("Enter string 1: ");
            str1 = Console.ReadLine();

            Console.WriteLine("Enter string 2: ");
            str2 = Console.ReadLine();

            if (str1 == str2)
                Console.WriteLine("They are equal");
            else
                Console.WriteLine("They are not equal");

            Console.Read();

        }
    }



}
