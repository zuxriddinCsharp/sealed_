using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_
{
    internal class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public static decimal TaxPercentage { get; set; }

        public Car(int id, string model, string brand, decimal price, decimal taxPercentage)
        {
            Id = id;
            Model = model;
            Brand = brand;
            Price = price;
            TaxPercentage = taxPercentage;
        }

        public decimal CalaulateTotal()
        {
            return Price - (Price * TaxPercentage / 100);
        }
    }
}
