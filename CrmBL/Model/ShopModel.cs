using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class ShopModel
    {
        Random rnd = new Random();
        Generator Generator = new Generator();
        public List<Sell> Sells { get; set; }

        public Queue<Cart> Carts { get; set; }

        public List<CashDesk> CashDesks { get; set; }

        public Queue<Seller> Sellers { get; set; }

        public List<Check> Checks { get; set; }

        public ShopModel()
        {
            var sellers = Generator.GetNewSellers(20);
            Generator.GetNewCustomers(100);
            Generator.GetNewProducts(1000);

            Checks = new List<Check>();
            Sells = new List<Sell>();
            Carts = new Queue<Cart>();
            Sellers = new Queue<Seller>();
            CashDesks = new List<CashDesk>();

            foreach (var seller in sellers)
            {
                Sellers.Enqueue(seller);
            }

            for (int i = 0; i < 3; i++)
            {
                CashDesks.Add(new CashDesk(CashDesks.Count, Sellers.Dequeue(), null));
            }
        }

        public void Start()
        {
            while (Generator.Customers.Count > 0)
            {
                var customers = Generator.GetCustomers(10);
                var carts = new Queue<Cart>();
                foreach (var customer in customers)
                {
                    var cart = new Cart(customer);
                    foreach (var product in Generator.GetProducts(1, 30))
                    {
                        cart.Add(product);
                    }
                    carts.Enqueue(cart);

                }
               
                while (carts.Count > 0)
                {
                    var cart = carts.Peek();
                    var cash = CashDesks[rnd.Next(0, CashDesks.Count)];
                    cash.Enqueue(cart);
                    carts.Dequeue();
                }

                for (int i = 0; i < 100; i++)
                {
                    var cash = CashDesks[rnd.Next(0, CashDesks.Count - 1)];
                    var money = cash.Dequeue();
                }
            }
           
        }
    }
}
