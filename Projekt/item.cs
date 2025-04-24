using System;

public class Item
{
    public string Name { get; }
    public decimal WeightKg { get; }
    public int WeirdnessLevel { get; }
    public bool IsFragile { get; }
    public Item(string name, decimal weightKg, int weirdnessLevel, bool isFragile)
	{
        Name = name;
        WeightKg = Math.Round(weightKg, 3);
        WeirdnessLevel = weirdnessLevel;
        IsFragile = isFragile;
    }
}
