using System;
using System.Collections.Generic;
using System.Text;
using MyFactoryFunction.ShopInterface;

namespace MyFactoryFunction.Factories
{
    internal class VinePlaceFactori:ShopFactories
    {
        private readonly decimal _price;
        private readonly string _description;

        public VinePlaceFactori(decimal price, string description)
        {
            _description = description;
            _price = price;
        }
        public override CommonInterface GetProducts()
        {
            VinePlace myPrice = new VinePlace(_price)
            {
                
                Description = _description
            };
            return myPrice;
        }
    }
}
