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

            if (num[0] > num[1] && num[0] > num[2])
            {
                Console.WriteLine("{0} is the largest", num[0]);
            }
            else if (num[1] > num[2])
            {
                Console.WriteLine("{0} is the largest", num[1]);
            }
            else
            {
                Console.WriteLine("{0} is the largest", num[2]);
            }

            Class1 code = new Class1();
            code.program2();

            Class2 code2 = new Class2();
            code2.program3();

            Console.Read();

        }



      


        
    }
}
