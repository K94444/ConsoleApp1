using System;

namespace ConsoleApp1
{
    public class Product
    {
        public string BarCode { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string barCode, string name, double price)
        {
            BarCode = barCode;
            Name = name;
            Price = price;
        }
    }
}