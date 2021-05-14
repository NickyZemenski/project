using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFour
{
    public class Product
    {
        public Product(string name, string description, double price)  // basic getting and setting for product class
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }
        public string name { get; set; }

        public string description { get; set; }

        public double price { get; set; }

        public override string ToString()
        {
            return $"{this.name}";
        }
    }
}
