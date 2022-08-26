using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    class Generator
    {
        Random rnd = new Random();
        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Seller> Sellers { get; set; } = new List<Seller>();
        public List<Product> Products { get; set; } = new List<Product>();

        public List<Customer> GetNewCustomers(int count)
        {
            var result = new List<Customer>();
            for (int i = 0; i < count; i++)
            {
                var customer = new Customer()
                {
                    CustomerId = Customers.Count,
                    Name = GetRandomText()
                };
                result.Add(customer);
                Customers.Add(customer);
            }
            return result;
        }

        public List<Seller> GetNewSellers(int count)
        {
            var result = new List<Seller>();
            for (int i = 0; i < count; i++)
            {
                var seller = new Seller()
                {
                    SellerId = Sellers.Count,
                    Name = GetRandomText()
                };
                result.Add(seller);
            }
            return result;
        }

        public List<Product> GetNewProducts(int count)
        {
            var result = new List<Product>();
            for (int i = 0; i < count; i++)
            {
                var product = new Product()
                {
                    ProductId = Products.Count,
                    Name = GetRandomText(),
                    Count = rnd.Next(10, 1000),
                    Price = Convert.ToDecimal(rnd.Next(5, 5000) + rnd.NextDouble())
                };
                result.Add(product);
                Products.Add(product);
            }
            return result;
        }

        public List<Product> GetProducts(int min, int max)
        {
            var result = new List<Product>();
            for (int i = min; i < max; i++)
            {
                result.Add(Products[rnd.Next(0, Products.Count)]);
            }
            return result;
        }

        public List<Customer> GetCustomers(int count)
        {
            var result = new List<Customer>();
            for (int i = 0; i < count; i++)
            {
                var customer = Customers[rnd.Next(0, Customers.Count)];
                result.Add(customer);
                Customers.Remove(customer);
            }
            return result;
        }

        public string GetRandomText()
        {
            return Guid.NewGuid().ToString().Substring(0, 5);
        }
    }
}
