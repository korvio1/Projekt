using System;
using System.Collections.Generic;

public class Warehouse
{
    private readonly int capacity;
    private readonly double maxTotalWeight;
    private readonly List<Item> items = new List<Item>();
    private double currentWeight = 0;

    public int CurrentItemCount => items.Count;

    public Warehouse(int capacity, double maxTotalWeight)
    {
        this.capacity = capacity;
        this.maxTotalWeight = Math.Round(maxTotalWeight, 3);
    }
    public (bool success, string message) AddItem(Item item)
    {
        if (items.Count >= capacity)
        {
            return (false, "Cannot add item: warehouse is full.");
        }

        if (currentWeight + item.WeightKg > maxTotalWeight)
        {
            return (false, "Cannot add item: weight limit exceeded.");
        }

        items.Add(item);
        currentWeight += item.WeightKg;
        return (true, "Item added successfully.");
    }
    public void ListAll()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item.Describe());
        }
    }
}
