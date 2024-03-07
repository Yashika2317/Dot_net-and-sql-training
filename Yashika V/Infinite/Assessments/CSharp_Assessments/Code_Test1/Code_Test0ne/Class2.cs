using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Test0ne
{
    class Class2
    {
        public void program3()
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

            Console.WriteLine("modified string:" , input);
            Console.Read();
        }
    }
    
}
