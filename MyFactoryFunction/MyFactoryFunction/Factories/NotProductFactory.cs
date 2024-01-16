using MyFactoryFunction.ShopInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFactoryFunction.Factories
{
    class NotProductFactory:ShopFactories
    {
        private readonly decimal _price;
        private readonly string _description;

        public NotProductFactory( string description)
        {
            _description = description;
            
        }
        public override CommonInterface GetProducts()
        {
            NotProduct myPrice = new NotProduct()
            {

                Description = _description
            };
            return myPrice;
        }
    }
}
