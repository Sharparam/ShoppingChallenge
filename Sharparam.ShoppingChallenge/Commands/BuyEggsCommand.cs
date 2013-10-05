using Sharparam.ShoppingChallenge.Items;

namespace Sharparam.ShoppingChallenge.Commands
{
    public class BuyEggsCommand : BuyCommand<Egg>
    {
        public BuyEggsCommand(ThisPoorGuy guy, int count) : base(guy, count)
        {

        }
    }
}
