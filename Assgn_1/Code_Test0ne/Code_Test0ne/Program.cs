using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Test0ne
{
     class Program
     {
         static void Main(string[] args)
         {

             Console.WriteLine("Program to check the largest number among 3 integers");
             int[] num = new int[3];
             int i, Maximum;

             Console.WriteLine("Input {0} numbers :\n");
             for (i = 0; i < 3; i++)
             {
                 Console.WriteLine("Numbers - {0} : ", i);
                 num[i] = Convert.ToInt32(Console.ReadLine());

             }

             if(num[0]>num[1] && num[0] > num[2])
             {
                 Console.WriteLine("{0} is the largest", num[0]);
             }else if (num[1] > num[2])
             {
                 Console.WriteLine("{0} is the largest", num[1]);
             }
             else
             {
                 Console.WriteLine("{0} is the largest", num[2]);
             }

             Console.Read();
         }



     class program2
     {
         static void Main(string[] args)
         {

             Console.WriteLine("Program to remove a letter from string at any given position");
             string str;
             int n;
             Console.WriteLine("Enter the string: ");
             str = Console.ReadLine();
             Console.WriteLine("Enter the position to be removed: ");
             n = Convert.ToInt32(Console.ReadLine());

             if (n > 0)
             {
                 Console.WriteLine( str.Remove(n, 1));

             }
             Console.Read();

         }
     }
    
    class program3
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter the string: ");
            input = Console.ReadLine();

            StringBuilder value = new StringBuilder(input);

            char A = input[0];
            char B = input[input.Length - 1];
          

            value[0] = B;
            value[input.Length - 1] = A;
            value.ToString();

            Console.WriteLine("Modified string: {0}", input);
            Console.Read();
      
        }
        

    }
}
