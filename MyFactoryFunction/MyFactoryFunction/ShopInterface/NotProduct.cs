using System;
using System.Collections.Generic;
using System.Text;

namespace MyFactoryFunction.ShopInterface
{
    class NotProduct : CommonInterface
    {
        private readonly string product;
        private readonly decimal price;
        public NotProduct()
        {
            product = "Not Found";
            price = 0;
            

        }
        public string Product => product;
        public string Description { get; set; }
        public decimal GetPrice() => price;
    }
}
