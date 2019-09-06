using System;

namespace Practicle
{
    public abstract class Product
    {
        public String id { get; set; }
        public String name { get; set; }
        public double price { get; set; }
        public String producer { get; set; }

        public Product()
        {
        }

        public Product(string id, string name, double price, string producer)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.producer = producer;
        }

        public abstract double computeTax();
    }
}