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
            double projectedWeight = Math.Round(currentWeight + item.WeightKg, 3);

            if (currentItemCount >= capacity)
                return (false, "Magazyn jest pełny.");

            if (projectedWeight > maxTotalWeight)
                return (false, $"Przekroczono maksymalną wagę magazynu. Aktualna waga: {currentWeight} kg, po dodaniu: {projectedWeight} kg (limit: {maxTotalWeight} kg).");

            items.Add(item);
            currentItemCount++;
            currentWeight = projectedWeight;

            return (true, "Przedmiot dodany.");
        }

        public void ListAll()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Magazyn jest pusty.");
                return;
            }

            Console.WriteLine("\nLista przedmiotów:");
            foreach (var item in items)
            {
                Console.WriteLine(item.Description());
            }
        }
    }
}
