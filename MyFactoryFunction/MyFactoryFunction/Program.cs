using MyFactoryFunction.Factories;
using MyFactoryFunction.ShopInterface;
using System;

namespace MyFactoryFunction
{
    class Program
    {

        static void Main(string[] args)
        {
            string myAnswers;
            Console.WriteLine("Hello World and my expencive user!");
            Console.WriteLine("Vine- Vine Place");
            Console.WriteLine("Enter you chose");

            myAnswers = Console.ReadLine();
            ShopFactories factories = GetFactories(myAnswers);
            CommonInterface display = factories.GetProducts();

            Console.WriteLine(
                $"\tProduct:\t{display.Product}\n" +
                $"\tDescription:\t{display.Description}\n" +
                $"\tPrice:\t{display.GetPrice()}"
                );
            Console.ReadLine();
            
        }
        private static ShopFactories GetFactories(string my)
        {
            
            switch (my.ToLower())
            {
                case "vine":
                    return new VinePlaceFactori(233524, "Is Very Good Vine");
                    
                default:
                    return new NotProductFactory("You aren`t entering worlds!");
            };
        }
        
           

        
        
    }
}
