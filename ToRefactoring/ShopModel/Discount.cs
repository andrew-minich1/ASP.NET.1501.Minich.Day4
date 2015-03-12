using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    public interface IGetDiscount
    {
        decimal ConsiderDiscount(decimal totalPrice);
        int DiscountPercent { get; set; }
    }
    public class Discount : IGetDiscount
    {
        public Discount(int discountPercent)
        {
            this.DiscountPercent = discountPercent;
        }
        private int discountPercent;
        public int DiscountPercent
        {
            get { return discountPercent; }
            set
            {
                if (value < 0 || value > 100) throw new ArgumentOutOfRangeException();
                discountPercent = value;
            }
        }
        public decimal ConsiderDiscount(decimal price)
        {
            return (price - (price / 100m * DiscountPercent));
        }
    }

}
