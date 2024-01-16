using MyFactoryFunction.ShopInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFactoryFunction.Factories
{
    internal abstract class ShopFactories
    {
        public abstract CommonInterface GetProducts();
        
    }
}
