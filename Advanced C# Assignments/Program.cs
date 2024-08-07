using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company(1, "Tech Corp");

            Product product1 = new Product(101, "Laptop");
            Product product2 = new Product(102, "Mouse");

            company.AddProduct(product1, 10);
            company.AddProduct(product2, 15);

            company.SellProduct(product1, 6);
            company.SellProduct(product2, 12);

            company.DisplayInventory();
        }
    }
}
