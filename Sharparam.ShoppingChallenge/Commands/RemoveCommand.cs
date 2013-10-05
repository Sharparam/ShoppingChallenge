using Sharparam.ShoppingChallenge.Items;

namespace Sharparam.ShoppingChallenge.Commands
{
    public class RemoveCommand<T> : ICommand where T : IItem
    {
        protected readonly ThisPoorGuy Guy;

        public readonly int Count;

        public RemoveCommand(ThisPoorGuy guy, int count)
        {
            Guy = guy;
            Count = count;
        }

        public void Execute()
        {
            Guy.Remove<T>(Count);
        }
    }
}
