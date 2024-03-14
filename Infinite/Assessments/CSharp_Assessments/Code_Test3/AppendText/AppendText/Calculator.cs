using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendText
{

    delegate int CalculatorDelegate(int x, int y);
    class Calculator
    {
        public static int Addition(int x, int y)
        {
            return x + y;
        }
        public static int Subtraction(int x, int y)
        {
            return x - y;
        }
        public static int Multiplication(int x, int y)
        {
            return x * y;
        }
    }
}
