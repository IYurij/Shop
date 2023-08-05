namespace Store
{
    public class Shop
    {
        private readonly Warehouse _warehouse;

        public Shop(Warehouse warehouse)
        {
            _warehouse = warehouse;
        }

        public string Paylink => "payment link";

        public Cart Cart()
        {
            return new Cart(this);
        }

        public void RemoveFromWarehouse(Good good, int goodsCount)
        {
            _warehouse.Remove(good, goodsCount);
        }
    }
}