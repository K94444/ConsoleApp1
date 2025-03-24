using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Klasa Product reprezentuje produkt w systemie
    class Product
    {
        // Właściwości klasy Product:
        public string BarCode;    // Kod kreskowy produktu (unikalny identyfikator)
        public string Name;        // Nazwa produktu
        public double Price;       // Cena produktu

        // Konstruktor klasy Product - służy do tworzenia nowych obiektów Product
        // Parametry:
        //   barCode - kod kreskowy produktu
        //   name - nazwa produktu
        //   price - cena produktu
        public Product(string barCode, string name, double price)
        {
            BarCode = barCode;  // Przypisanie wartości kodu kreskowego
            Name = name;        // Przypisanie nazwy produktu
            Price = price;      // Przypisanie ceny produktu
        }
    }
}