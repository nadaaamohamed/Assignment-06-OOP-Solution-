using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06_OOP.Third_Project
{
    internal class GuestUser : User
    {
        public override Discount GetDiscount()
        {
            return new PercentageDiscount("Guest User", 0); 
        }

       

    }
}
