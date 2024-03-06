using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Doctor
    {
        private int RegnNo;
        private string Name;
        private double FeesCharged;
   
        public void set(int regnNo, string name, double feesCharged)
        {
            this.RegnNo = regnNo;
            this.Name = name;
            this.FeesCharged = feesCharged;
        }
        public void Doctor_Display()
        {
            Console.WriteLine("Doctor Details:");
            Console.WriteLine("Registration Number: " + RegnNo);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Fees Charged: " + FeesCharged);
        }
    }



