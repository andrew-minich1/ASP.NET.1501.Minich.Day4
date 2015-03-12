using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopModel
{
    public interface IGetSumm
    {
        decimal ValueProducts(IEnumerable<Product> products);
    }

    #region DefaultValueCalculator
    public class DefaultValueCalculator : IGetSumm
    {
        private IGetDiscount discount;
        public DefaultValueCalculator(IGetDiscount discount)
        {
            this.discount = discount;
        }
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            if (products == null || discount == null) throw new NullReferenceException();
            decimal sumOfProduct = 0;
            foreach (var product in products)
            {
                sumOfProduct += discount.ConsiderDiscount(product.Price);
            }
            return sumOfProduct;
        }
    } 
    #endregion

    #region SpecialValueCalculator
    public class SpecialValueCalculator : IGetSumm
    {
        private IGetDiscount discount;
        public SpecialValueCalculator(IGetDiscount discount)
        {
            this.discount = discount;
        }
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            if (products == null || discount == null) throw new NullReferenceException();
            decimal sumOfProduct = 0;
            foreach (var product in products)
            {
                sumOfProduct += discount.ConsiderDiscount(product.Price / 2);
            }
            return sumOfProduct;
        }
    } 
    #endregion
}
