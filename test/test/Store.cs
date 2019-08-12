using System;
using System.Collections.Generic;

namespace test
{
    public class Store
    {
        public List<Product> ProductList = new List<Product>();

        public void AddProduct(string id, string name, int price)
        {
            foreach (Product p in ProductList)
            {
                if (p.Id.Equals(id))
                {
                    Console.WriteLine("*Error: Duplicate product ID.");
                    return;
                }
            }
            Product pro = new Product(id, name, price);
            ProductList.Add(pro);
        }

        public void DeleteProduct(string id)
        {
            foreach (Product p in ProductList)
            {
                if (p.Id.Equals(id))
                {
                    ProductList.Remove(p);
                    Console.WriteLine("Success!");
                    return;
                }
            }
            Console.WriteLine("*Error: No such ID found.");
        }

        public void DisplayProduct()
        {
            foreach (Product p in ProductList)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Product ID: "+p.Id+".");
                Console.WriteLine("__________________");
                Console.WriteLine("Product Name: "+p.Name+".");
                Console.WriteLine("Price: $"+p.Price+".");
                Console.WriteLine("__________________");
                Console.WriteLine("------------------------");
            }
        }
    }
}