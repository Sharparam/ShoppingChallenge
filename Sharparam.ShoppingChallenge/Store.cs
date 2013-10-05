using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Sharparam.ShoppingChallenge.Items;

namespace Sharparam.ShoppingChallenge
{
    public class Store
    {
        private readonly List<IItem> _items;
        public IReadOnlyList<IItem> Items { get; private set; }
        

        public Store()
        {
            _items = new List<IItem>();
            Items = new ReadOnlyCollection<IItem>(_items);
        }

        public void Add<T>(int count = 1) where T : IItem, new()
        {
            if (count < 1)
                throw new ArgumentOutOfRangeException("count");

            if (count == 1)
                _items.Add(new T());
            else
            {
                var toAdd = new List<IItem>();
                for (var n = 0; n < count; n++)
                    toAdd.Add(new T());
                _items.AddRange(toAdd);
            }
        }

        public void Add(IEnumerable<IItem> items)
        {
            _items.AddRange(items);
        }

        public IEnumerable<IItem> Purchase<T>(int count = 1) where T : IItem
        {
            if (count < 1)
                throw new ArgumentOutOfRangeException("count");

            var matching = _items.Where(i => i is T);
            var items = matching as IItem[] ?? matching.ToArray();

            if (items.Length < count)
                throw new Exception("Store doesn't have that many items of type " + typeof (T));

            var result = items.Take(count);
            var purchased = result as IItem[] ?? result.ToArray();
            
            _items.RemoveAll(purchased.Contains);
            
            return purchased;
        }
    }
}
