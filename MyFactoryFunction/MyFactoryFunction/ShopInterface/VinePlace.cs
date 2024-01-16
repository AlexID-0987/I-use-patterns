using System;
using System.Collections.Generic;
using System.Text;

namespace MyFactoryFunction.ShopInterface
{
    internal class VinePlace:CommonInterface
    {
        private readonly string _product;
        private readonly decimal _price;
        public VinePlace(decimal price)
        {
            _product = "Bordo";
            _price = price*2;
        }
        public string Product => _product;
        public string Description { get; set; }
        public decimal GetPrice() => _price;
    }
}
