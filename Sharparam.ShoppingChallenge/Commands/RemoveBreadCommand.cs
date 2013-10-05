using Sharparam.ShoppingChallenge.Items;

namespace Sharparam.ShoppingChallenge.Commands
{
    public class RemoveBreadCommand : RemoveCommand<Bread>
    {
        public RemoveBreadCommand(ThisPoorGuy guy, int count) : base(guy, count)
        {

        }
    }
}
