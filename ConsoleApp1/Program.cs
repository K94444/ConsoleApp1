using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager manager = new ProductManager();

            while (true)
            {
                Console.WriteLine("\nWybierz opcję:");
                Console.WriteLine("1. Wyświetl listę produktów");
                Console.WriteLine("2. Dodaj produkt");
                Console.WriteLine("3. Usuń produkt");
                Console.WriteLine("4. Zaaktualizuj produkt");
                Console.WriteLine("5. Oblicz wartość magazynu");
                Console.WriteLine("6. Wyjście");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        manager.ShowProducts();
                        break;
                    case "2":
                        manager.AddProduct();
                        break;
                    case "3":
                        manager.RemoveProduct();
                        break;
                    case "4":
                        manager.UpdateProducts();
                        break;
                    case "5":
                        manager.CalculateProducts(); // Poprawione z 'menager' na 'manager'
                        break;
                    case "6":
                        Console.WriteLine("Zamykanie programu...");
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór. Wybierz opcję od 1 do 6.");
                        break;
                }
            }
        }
    }
}