using System;

namespace Projekt
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter warehouse capacity: ");
            int capacity = int.Parse(Console.ReadLine());

            Console.Write("Enter max total weight (kg): ");
            double maxWeight = double.Parse(Console.ReadLine());

            Warehouse warehouse = new Warehouse(capacity, maxWeight);

            while (true)
            {
                Console.WriteLine("\nOptions:");
                Console.WriteLine("1 - Add item");
                Console.WriteLine("2 - List all items");
                Console.WriteLine("3 - Exit");
                Console.Write("Choose: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Item name: ");
                    string name = Console.ReadLine();

                    Console.Write("Weight (kg): ");
                    double weight = double.Parse(Console.ReadLine());

                    Console.Write("Weirdness level (1-10): ");
                    int weirdness = int.Parse(Console.ReadLine());

                    Console.Write("Is it fragile? (yes/no): ");
                    bool isFragile = Console.ReadLine().ToLower() == "yes";

                    Item item = new Item(name, weight, weirdness, isFragile);
                    var (success, message) = warehouse.AddItem(item);
                    Console.WriteLine(message);
                }
            }
        }
    }
}