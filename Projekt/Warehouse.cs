using System;
using System.Collections.Generic;

public class Warehouse
{
    private readonly int capacity;
    private readonly double maxTotalWeight;
    private readonly List<Item> items = new List<Item>();
    private double currentWeight = 0;

    public int CurrentItemCount => items.Count;

    public Warehouse(int capacity, double maxTotalWeight);

    public Warehouse()
	{
	}
}
