using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using Sharparam.ShoppingChallenge.Items;

namespace Sharparam.ShoppingChallenge
{
    public class Shopper
    {
        private decimal _funds;
        private Cart _cart;
        private Store _store;

        public decimal Funds
        {
            get { return _funds; }
        }

        public Cart Cart { get { return _cart; } }

        public Shopper(decimal funds, Store store)
        {
            _funds = funds;
            _cart = new Cart();
            _store = store;
            _cart.Items.CollectionChanged += ItemsOnCollectionChanged;
        }

        private void ItemsOnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IItem item in e.NewItems)
                        Pay(item.Price);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (var old in e.OldItems.Cast<IItem>().Where(old => !_cart.Items.Contains(old)))
                        Earn(old.Price);
                    break;
            }
        }

        public void Buy<T>(int count) where T : IItem
        {
            var items = _store.Purchase<T>(count);
            _cart.Items.AddRange(items);
        }

        public void Remove<T>(int count) where T : IItem
        {
            var items = _cart.Items.Where(i => i is T).Take(count);
            var enumerable = items as IItem[] ?? items.ToArray();
            _store.Add(enumerable);
            foreach (var item in enumerable)
                _cart.Items.Remove(item);
        }

        public void Pay(decimal amount)
        {
            amount = Math.Abs(amount);

            if (amount > _funds)
                throw new InsufficientFundsException();

            _funds -= amount;
        }

        public void Earn(decimal amount)
        {
            _funds += Math.Abs(amount);
        }
    }
}
