using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Test0ne
{
    class Class1
    {
        public void program2()
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
                Console.WriteLine(str.Remove(n, 1));

            }
            Console.Read();
        }
    }
}
