using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__Assignments
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Product(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}";
        }
    }

    public class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
        private Dictionary<Product, int> inventory = new Dictionary<Product, int>();

        public Company(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public void AddProduct(Product product, int quantity)
        {
            if (inventory.ContainsKey(product))
            {
                inventory[product] += quantity;
            }
            else
            {
                inventory[product] = quantity;
            }
        }

        public void SellProduct(Product product, int quantity)
        {
            if (inventory.ContainsKey(product) && inventory[product] >= quantity)
            {
                inventory[product] -= quantity;
                if (inventory[product] < 5)
                {
                    Console.WriteLine($"Warning: Product {product.Name} quantity is less than 5");
                }
            }
            else
            {
                Console.WriteLine("Not enough product quantity to sell");
            }
        }

        public void DisplayInventory()
        {
            foreach (var item in inventory)
            {
                Console.WriteLine($"Product: {item.Key.Name}, Quantity: {item.Value}");
            }
        }
    }

    public class Supplier
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Supplier(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
