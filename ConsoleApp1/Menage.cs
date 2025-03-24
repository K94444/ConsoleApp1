using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class ProductManager
    {
        private List<Product> products = new List<Product>();

        public void ShowProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("Lista produktów jest pusta.");
                return;
            }

            Console.WriteLine("\nLista produktów:");
            foreach (var product in products)
            {
                Console.WriteLine($"Nazwa: {product.Name} | Cena: {product.Price} zł | Kod: {product.BarCode}");
            }
        }

        public void AddProduct()
        {
            Console.WriteLine("\nDodawanie nowego produktu:");

            Console.Write("Podaj kod kreskowy: ");
            string barCode = Console.ReadLine();

            Console.Write("Podaj nazwę produktu: ");
            string name = Console.ReadLine();

            Console.Write("Podaj cenę produktu: ");
            if (double.TryParse(Console.ReadLine(), out double price))
            {
                products.Add(new Product(barCode, name, price));
                Console.WriteLine("Produkt został dodany.");
            }
            else
            {
                Console.WriteLine("Nieprawidłowy format ceny.");
            }
        }

        public void RemoveProduct()
        {
            Console.WriteLine("\nUsuwanie produktu:");
            Console.Write("Podaj kod kreskowy produktu do usunięcia: ");
            string barCode = Console.ReadLine();

            var productToRemove = products.Find(p => p.BarCode == barCode);
            if (productToRemove != null)
            {
                products.Remove(productToRemove);
                Console.WriteLine("Produkt został usunięty.");
            }
            else
            {
                Console.WriteLine("Nie znaleziono produktu o podanym kodzie.");
            }
        }

        public void UpdateProducts()
        {
            Console.WriteLine("\nAktualizacja produktu:");
            Console.Write("Podaj nazwe produktu do aktualizacji: ");
            string barCode = Console.ReadLine();

            var productToUpdate = products.Find(p => p.BarCode == barCode);
            if (productToUpdate != null)
            {
                Console.WriteLine($"Aktualne dane: Nazwa: {productToUpdate.Name}, Cena: {productToUpdate.Price} ");

                Console.Write("Nowa nazwa (pozostaw puste aby nie zmieniać): ");
                string newName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newName))
                {
                    productToUpdate.Name = newName;
                }

                Console.Write("Nowa cena (pozostaw puste aby nie zmieniać): ");
                string priceInput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(priceInput) && double.TryParse(priceInput, out double newPrice))
                {
                    productToUpdate.Price = newPrice;
                }

                Console.WriteLine("Produkt został zaktualizowany.");
            }
            else
            {
                Console.WriteLine("Nie znaleziono produktu o podanym kodzie kreskowym.");
            }
        }

        public void CalculateProducts()
        {
            double totalValue = products.Sum(p => p.Price);
            Console.WriteLine($"\nWartość magazynu: {totalValue.ToString("0.00")} zł");
            Console.WriteLine($"Liczba produktów: {products.Count}");
        }
    }
}