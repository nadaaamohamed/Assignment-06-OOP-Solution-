using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06_OOP.Third_Project
{
    internal class RegularUser : User
    {
        public override Discount GetDiscount()
        {
            return new PercentageDiscount("Regular User", 5);
        }
       
    }
}
    

