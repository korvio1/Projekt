using System;

namespace Projekt
{
    class Item
    {
        public string Name { get; }
        public double WeightKg { get; }
        public int WeirdnessLevel { get; }
        public bool IsFragile { get; }

        public Item(string name, double weightKg, int weirdnessLevel, bool isFragile)
        {
            Name = name;
            WeightKg = Math.Round(weightKg, 3);
            WeirdnessLevel = weirdnessLevel;
            IsFragile = isFragile;
        }

        public string Description()
        {
            return $"{{\n\t\"nazwa\": \"{Name}\",\n\t\"waga_kg\": {WeightKg},\n\t\"poziom_dziwnosci\": {WeirdnessLevel},\n\t\"czy_delikatny\": {(IsFragile ? "TAK" : "NIE")}\n}}";
        }
    }
}
