using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06_OOP.Third_Project
{
    internal abstract class User
    {
        public string ? Name { get; set; }

        public abstract Discount GetDiscount();



    }
}
