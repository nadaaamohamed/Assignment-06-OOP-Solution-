using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06_OOP.Third_Project
{
    internal class FlatDiscount : Discount
    {
       public  decimal  FlatAmount { get; set; }
        public FlatDiscount(string name,  decimal amount)
        {
            Name = name;
            FlatAmount = amount;
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            decimal discountAmount = (quantity >= 1) ? FlatAmount : 0;

            return discountAmount;
        }
    }
   
}
