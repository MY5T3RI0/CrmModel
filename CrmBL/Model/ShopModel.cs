using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        public int CashDeskSpeed { get; set; } = 300;
        public int CustomerSpeed { get; set; } = 1000;

        CancellationTokenSource cancelTokenSource;
        CancellationToken token;

        List<Task> tasks = new List<Task>();

        public ShopModel(int count)
        {
            var sellers = Generator.GetNewSellers(20);
            Generator.GetNewCustomers(100);
            Generator.GetNewProducts(1000);

            cancelTokenSource = new CancellationTokenSource();
            token = cancelTokenSource.Token;

            Checks = new List<Check>();
            Sells = new List<Sell>();
            Carts = new Queue<Cart>();
            Sellers = new Queue<Seller>();
            CashDesks = new List<CashDesk>();

            foreach (var seller in sellers)
            {
                Sellers.Enqueue(seller);
            }

            for (int i = 0; i < count; i++)
            {
                CashDesks.Add(new CashDesk(CashDesks.Count, Sellers.Dequeue(), null));
            }
        }

        public void Start()
        {
            tasks.Add(new Task(() => CreateCarts(10, token)));
            tasks.AddRange(CashDesks.Select(c => new Task(() => CashDeskWork(c, token))));

            foreach (var task in tasks)
            {
                task.Start();
            }
        }

        public void Stop()
        {
            cancelTokenSource.Cancel();
        }

        private void CashDeskWork(CashDesk cashDesk, CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                if (cashDesk.Carts.Count > 0)
                {
                    cashDesk.Dequeue();
                    Thread.Sleep(CashDeskSpeed);
                }
            }
        }

        private void CreateCarts(int count, CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                var customers = Generator.GetNewCustomers(count);
                foreach (var customer in customers)
                {
                    var cart = new Cart(customer);
                    foreach (var product in Generator.GetProducts(1, 30))
                    {
                        cart.Add(product);
                    }
                    var cash = CashDesks[rnd.Next(0, CashDesks.Count)];
                    cash.Enqueue(cart);
                }

                Thread.Sleep(CustomerSpeed);
            }
        }
    }
}
