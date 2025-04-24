using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter warehouse capacity: ");
        int capacity = int.Parse(Console.ReadLine());

        Console.Write("Enter max total weight (kg): ");
        double maxWeight = double.Parse(Console.ReadLine());

        Warehouse warehouse = new Warehouse(capacity, maxWeight);


    }