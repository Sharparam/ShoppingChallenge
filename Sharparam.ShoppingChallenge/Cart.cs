using System.Collections.ObjectModel;
using System.Linq;
using Sharparam.ShoppingChallenge.Items;

namespace Sharparam.ShoppingChallenge
{
    public class Cart
    {
        public ObservableCollection<IItem> Items;

        public decimal Value
        {
            get { return Items.Aggregate((decimal) 0, (val, item) => val + item.Price); }
        }

        public Cart()
        {
            Items = new ObservableCollection<IItem>();
        }
    }
}
