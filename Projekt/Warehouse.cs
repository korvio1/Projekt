using System;
using System.Collections.Generic;

namespace Projekt
{
    class Warehouse
    {
        private readonly int capacity;
        private int currentItemCount = 0;
        private readonly double maxTotalWeight;
        private double currentWeight = 0;

        private List<Item> items = new List<Item>();

        public Warehouse(int capacity, double maxTotalWeight)
        {
            this.capacity = capacity;
            this.maxTotalWeight = Math.Round(maxTotalWeight, 3);
        }

        public (bool, string) AddItem(Item item)
        {
            if (currentItemCount >= capacity)
                return (false, "Warehouse is full.");

            if (currentWeight + item.WeightKg > maxTotalWeight)
                return (false, "Adding this item would exceed weight limit.");

            items.Add(item);
            currentItemCount++;
            currentWeight += item.WeightKg;

            return (true, "Item added successfully.");
        }

        public void ListAll()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.Description());
            }
        }
    }
}
