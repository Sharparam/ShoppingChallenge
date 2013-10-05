namespace Sharparam.ShoppingChallenge
{
    public class ThisPoorGuy : Shopper
    {
        public readonly Brain Brain;
        public readonly Wife Wife;

        public ThisPoorGuy(decimal funds, Store store) : base(funds, store)
        {
            Brain = new Brain();
            Wife = new Wife(this);
        }
    }
}
