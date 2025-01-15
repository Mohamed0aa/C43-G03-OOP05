using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal abstract  class Discount
    {
        public double discount { get; set; }

        public abstract decimal CalculateDiscount(decimal price, int quantity) ;

    }

    class PercentageDiscount : Discount
    {
        public double percentage { get; set; }

        public PercentageDiscount(double percentage)
        {
            this.percentage =percentage;
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            discount = (double)(price * quantity);
            discount*=(percentage/100);
            return (decimal)discount;
        }

    }

    class FlatDiscount : Discount
    {
        public decimal Flat_Amount { get; set; }
        public FlatDiscount(decimal f)
        {
            Flat_Amount = f;
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            discount = (double)Flat_Amount * Math.Min(quantity, 1);

            return (decimal)discount;
        }
    }

    class BuyOneGetOneDiscount : Discount
    {
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
           if (quantity >1)
            {
                discount = (double)((price/2) *( quantity/2));
                return (decimal)discount;
            }
           return price*quantity;
        }
    }

    abstract class User 
    {
        public string name { get; set; }

        public abstract Discount GetDiscount();
    }
    class RegularUser : User
    {
        public override Discount GetDiscount()
        {
            return new PercentageDiscount(10);
        }
    }

    class PremiumUser : User
    {
        public override Discount GetDiscount()
        {
            return new FlatDiscount(100);
        }
    }
    class GuestUser : User
    {
        public override Discount GetDiscount()
        {
            return null;
        }
    }







}
