using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgn_3
{
    public class Scholarship
    {
        public double Merit(int marks, double fees)
        {
            double Scholarship_Amount = 0;

            if (marks >= 70 && marks <= 80)
            {
                Scholarship_Amount = 0.20 * fees;
            }
            else if (marks > 80 && marks <= 90)
            {
                Scholarship_Amount = 0.30 * fees; 
            }
            else if (marks > 90)
            {
                Scholarship_Amount = 0.50 * fees;
            }

            return Scholarship_Amount;
        }
        

    }
}
