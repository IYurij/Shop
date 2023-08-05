using System;
using System.Collections.Generic;

namespace Store
{
    public class Cart
    {
        private readonly Shop _shop;
        private List<Good> _goodsList;

        public Cart(Shop shop)
        {
            _shop = shop;
            _goodsList = new List<Good>();
        }

        public void Add(Good good, int goodsCount)
        {
            for (int i = 0; i < goodsCount; i++)
                _goodsList.Add(good);

            _shop.RemoveFromWarehouse(good, goodsCount);
        }

        public void Show()
        {
            foreach (var good in _goodsList)
            {
                Console.WriteLine($"Name: {good.Name}");
            }
        }

        public Shop Order()
        {
            return _shop;
        }
    }
}