using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Day4_HW.Task1
{
    class Product : IComparable<Product>
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double Price { get; private set; }

        public Product(string Name, string Description, int Price)
        {
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
        }

        int IComparable<Product>.CompareTo(Product other)
        {
            if (other.Price > Price)
                return -1;
            else if (other.Price == Price)
                return 0;
            else
                return 1;
        }
    }
}
