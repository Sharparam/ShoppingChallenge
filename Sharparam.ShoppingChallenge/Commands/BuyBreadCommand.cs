using Sharparam.ShoppingChallenge.Items;

namespace Sharparam.ShoppingChallenge.Commands
{
    public class BuyBreadCommand : BuyCommand<Bread>
    {
        public BuyBreadCommand(ThisPoorGuy guy, int count) : base(guy, count)
        {

        }
    }
}
