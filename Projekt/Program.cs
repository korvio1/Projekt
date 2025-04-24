using System;

namespace Projekt
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj pojemność magazynu: ");
            int capacity = int.Parse(Console.ReadLine());

            Console.Write("Podaj maksymalną łączną wagę kg: ");
            double maxWeight = double.Parse(Console.ReadLine());

            Warehouse warehouse = new Warehouse(capacity, maxWeight);

            while (true)
            {
                Console.WriteLine("\nOpcje:");
                Console.WriteLine("1 - Dodaj przedmiot");
                Console.WriteLine("2 - Podaj listę przedmiotów");
                Console.WriteLine("3 - Wyjdź");
                Console.Write("Wybierz: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Nazwa przedmiotu: ");
                    string name = Console.ReadLine();

                    Console.Write("Waga kg: ");
                    double weight = double.Parse(Console.ReadLine());

                    Console.Write("Poziom dziwności 1-10: ");
                    int weirdness = int.Parse(Console.ReadLine());

                    Console.Write("Czy przedmiot jest delikatny? (tak/nie): ");
                    bool isFragile = Console.ReadLine().ToLower() == "tak";

                    Item item = new Item(name, weight, weirdness, isFragile);
                    var (success, message) = warehouse.AddItem(item);
                    Console.WriteLine(message);
                }
                else if (choice == "2")
                {
                    warehouse.ListAll();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Wychodzenie.");
                    break;
                }
                else
                {
                    Console.WriteLine("Nie ma takiej opcji.");
                }
            }
        }
    }
}
