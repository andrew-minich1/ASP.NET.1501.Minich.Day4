using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace ShopModel
{
    class ConfigModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IGetDiscount>().To<Discount>().WithConstructorArgument("discountPercent", 110);
            this.Bind<IGetSumm>().To<DefaultValueCalculator>();
            this.Bind<ShoppingCart>().ToSelf();
        }
    }

    class ConfigModule2 : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IGetDiscount>().To<Discount>().WithConstructorArgument("discountPercent", 20);
            this.Bind<IGetSumm>().To<DefaultValueCalculator>();
            this.Bind<ShoppingCart>().ToSelf();
        }
    }

}
