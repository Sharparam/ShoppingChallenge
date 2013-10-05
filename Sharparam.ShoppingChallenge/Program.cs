using System;
using System.Linq;
using Sharparam.ShoppingChallenge.Items;

namespace Sharparam.ShoppingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new Store();
            store.Add<Egg>(999);
            store.Add<Bread>(999);

            var shopper = new ThisPoorGuy(12000, store);

            var wife = new Wife(shopper);

            Console.WriteLine(shopper.Funds);

            wife.DemandEggs(12);

            Console.WriteLine("Store has {0} eggs, shopper has {1} eggs, shopper has {2} funds. Shopper's cart is worth {3}",
                              store.Items.Count(i => i is Egg), shopper.Cart.Items.Count(i => i is Egg),
                              shopper.Funds, shopper.Cart.Value);

            Console.ReadLine();
        }
    }
}
