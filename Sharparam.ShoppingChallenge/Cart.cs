using System.Collections.ObjectModel;
using Sharparam.ShoppingChallenge.Items;

namespace Sharparam.ShoppingChallenge
{
    public class Cart
    {
        public ObservableCollection<IItem> Items;

        public Cart()
        {
            Items = new ObservableCollection<IItem>();
        }
    }
}
