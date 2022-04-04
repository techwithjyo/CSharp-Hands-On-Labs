using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            Discount discount = new Discount();
            var discountAmount = discount.CalculateDiscount(1500, "Kolkata");

            DiscountForKolkata discountForKolkata = new DiscountForKolkata();
            var discountAmount1 = discountForKolkata.CalculateDiscount(1500, "Kolkata");

            Console.WriteLine(discountAmount+ " "+ discountAmount1);
            Console.ReadLine();
        }
    }
    public class Discount
    {
        public virtual int CalculateDiscount(int price, string place)
        { 
            if(price>1000)
            {
                int discount = price * 5 / 100;
                price -= discount;
                return discount;
            }
            return 0;
        }
    }
    public class DiscountForKolkata : Discount
    {
        public override int CalculateDiscount(int price, string place)
        {
            if (price > 1000 && ("kolkata" == place.ToLower()))
            {
                int discount = price * 90 / 100;
                price -= discount;
                return discount;
            }
            return 0;
        }
    }

}
