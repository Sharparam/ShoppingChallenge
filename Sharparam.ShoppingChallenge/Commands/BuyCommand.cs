using Sharparam.ShoppingChallenge.Items;

namespace Sharparam.ShoppingChallenge.Commands
{
    public class BuyCommand<T> : ICommand where T : IItem
    {
        protected readonly ThisPoorGuy Guy;

        public readonly int Count;

        public BuyCommand(ThisPoorGuy guy, int count)
        {
            Guy = guy;
            Count = count;
        }

        public void Execute()
        {
            Guy.Buy<T>(Count);
        }
    }
}
