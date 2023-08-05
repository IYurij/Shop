using System;
using System.Collections.Generic;
using System.Linq;

namespace Store
{
    public class Warehouse
    {
        private readonly List<WarehouseCell> _cellsList;

        public Warehouse()
        {
            _cellsList = new List<WarehouseCell>();
        }

        public void Delive(Good good, int count)
        {
            _cellsList.Add(new WarehouseCell(good, count));
        }

        public void ShowGoods()
        {
            foreach (var cell in _cellsList)
            {
                Console.WriteLine($"Good name: {cell.Name}, Goods count: {cell.Count}");
            }
        }

        public void Remove(Good good, int count)
        {
            WarehouseCell cell = _cellsList.Where(x => x.Name == good.Name).FirstOrDefault();

            if (cell.Count - count < 0 || cell == null)
            {
                throw new ArgumentOutOfRangeException();
            }

            cell.Count -= count;
        }
    }

    public class WarehouseCell
    {
        public string Name;
        public int Count;

        public WarehouseCell(Good good, int goodsCount)
        {
            Name = good.Name;
            Count = goodsCount;
        }
    }
}