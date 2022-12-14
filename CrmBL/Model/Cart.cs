using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class Cart : IEnumerable
    {
        public int Number { get; set; }

        public Customer Customer { get; set; }

        public Dictionary<Product, int> Products { get; set; }

        public decimal Price => GetAll().Sum(p => p.Price);

        public Cart(Customer customer)
        {
            Customer = customer;
            Products = new Dictionary<Product, int>();
        }

        public void Add(Product product)
        {
            if(!Products.TryGetValue(product, out int count))
            {
                Products.Add(product, 1);
            }
            else
            {
                Products[product] = ++count;
            }           
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var product in Products.Keys)
            {
                for (int i = 0; i < Products[product]; i++)
                {
                    yield return product;
                }
            }
        }

        public List<Product> GetAll()
        {
            var result = new List<Product>();
            foreach (Product product in this)
            {
                result.Add(product);
            }

            return result;
        }
    }
}
