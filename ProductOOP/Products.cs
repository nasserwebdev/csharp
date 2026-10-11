using System;
using System.Collections.Generic;
using System.Text;

namespace L5
{
    public class Products
    {
        public Products()
        {

        }
        public Products(string name, string cat, int qty, double price)
        {
            Name = name;
            Category = cat;
            Quantity = qty;
            Price = price;
        }
        public string Name { get; set; }
        public string Category { get; set; }
        private int _Quantity { get; set; }
        public int Quantity
        {
            get
            {
                return _Quantity;
            }
            set
            {
                if (value < 1)
                {
                    throw new Exception("Product quantity must be greater than 0");
                }
                _Quantity = value;
            }
        }
        public double Price { get; set; }

        public string DisplayProductDetails()
        {
            Console.WriteLine("Enter product name");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Category");
            Category = Console.ReadLine();

            Console.WriteLine("Enter Quantity");
            Quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Price");
            Price = Convert.ToDouble(Console.ReadLine());

            return $"Product Details: Product Name: {Name}, Category: {Category}, QTY: {Quantity}, Price: {Price}";
        }
    }
}
