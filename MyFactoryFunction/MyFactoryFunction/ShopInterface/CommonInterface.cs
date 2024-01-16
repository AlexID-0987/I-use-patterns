using System;
using System.Collections.Generic;
using System.Text;

namespace MyFactoryFunction.ShopInterface
{
    internal interface CommonInterface
    {
        string Product { get;}
        string Description { get; set; }
        decimal GetPrice();
    }
}
