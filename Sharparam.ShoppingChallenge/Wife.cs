using Sharparam.ShoppingChallenge.Commands;

namespace Sharparam.ShoppingChallenge
{
    public class Wife
    {
        private ThisPoorGuy _husband;

        public Wife(ThisPoorGuy husband)
        {
            _husband = husband;
        }

        public void DemandEggs(int count = 1)
        {
            _husband.Brain.Process(new BuyEggsCommand(_husband, count));
        }

        public void DemandBread(int count = 1)
        {
            _husband.Brain.Process(new BuyBreadCommand(_husband, count));
        }

        public void RegretEggs(int count = 1)
        {
            _husband.Brain.Process(new RemoveEggsCommand(_husband, count));
        }

        public void RegredBread(int count = 1)
        {
            _husband.Brain.Process(new RemoveBreadCommand(_husband, count));
        }
    }
}
