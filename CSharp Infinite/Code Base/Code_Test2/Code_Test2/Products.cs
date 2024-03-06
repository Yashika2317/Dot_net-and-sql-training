using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Test2
{
    public class Products
    {
        public int Product_id;
        public string Product_Name;
        public double Price;

        public Products(int Product_id, string Product_Name, double Price)
        {
            this.Product_id = Product_id;
            this.Product_Name = Product_Name;
            this.Price = Price;
        }


    }
}
