using System.Collections.Generic;
using System.Collections.ObjectModel;
using Sharparam.ShoppingChallenge.Items;

namespace Sharparam.ShoppingChallenge
{
    public static class Extensions
    {
        public static void AddRange(this ObservableCollection<IItem> coll, IEnumerable<IItem> items)
        {
            foreach (var item in items)
                coll.Add(item);
        }
    }
}
