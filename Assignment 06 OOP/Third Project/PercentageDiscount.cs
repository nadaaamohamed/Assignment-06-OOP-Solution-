using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06_OOP.Third_Project
{
    internal class PercentageDiscount : Discount
    {
        public decimal Percentage { get; set; }
        public PercentageDiscount(string name, decimal percentage)
        {
            Name = name;
            Percentage = percentage;
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return (price *  quantity) *Percentage/100;
        }
    }
    
}
