using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    public class ShoppingCart
    {
        private IGetSumm valueCalc { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public ShoppingCart(IGetSumm valueCalc)
        {
            this.valueCalc = valueCalc;
        }

        public decimal CalculateProductTotal()
        {
            if (valueCalc == null) throw new NullReferenceException();
            return valueCalc.ValueProducts(Products);
        }
    }
}
