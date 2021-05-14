using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFour
{
    public class Procedure:Product  // makes it so all procedures are products but not all products are procedures due to inheritance
    {

        public Procedure(string name, string description, double price, int minutes)  // gets and sets the base from product and adds minutes for procedures
            :base(name,description,price)
        {
           
            this.minutes = minutes;
        }

  
        public int minutes { get; set; }

        public override string ToString()
        {
            return $"{this.name}";  // this basically shows up in our list when we need to display 
        }
    }
}
