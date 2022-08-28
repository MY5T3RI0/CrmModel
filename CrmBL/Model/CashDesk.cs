using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class CashDesk
    {
        CrmContext db;

        public int Number { get; set; }

        public Seller Seller { get; set; }

        public Queue<Cart> Carts { get; set; }

        public int MaxQueue { get; set; }

        public bool IsModel { get; set; }

        public int ExitCustomer { get; set; }

        public EventHandler<Check> CartOut;

        public CashDesk(int number, Seller seller, CrmContext db)
        {
            Number = number + 1;
            Seller = seller;
            Carts = new Queue<Cart>();
            IsModel = true;
            MaxQueue = 10;
            this.db = db ?? new CrmContext();
        }

        public void Enqueue(Cart cart)
        {
            if (Carts.Count < MaxQueue)
            {
                Carts.Enqueue(cart);
            }
            else
            {
                ExitCustomer++;
            }
        }

        public decimal Dequeue()
        {
            decimal sum = 0;

            if (Carts.Count == 0)
            {
                return 0;
            }

            var cart = Carts.Dequeue();

            if (cart != null)
            {
                var check = new Check()
                {
                    Created = DateTime.Now,
                    SellerId = Seller.SellerId,
                    Seller = Seller,
                    Customer = cart.Customer,
                    CustomerId = cart.Customer.CustomerId
                };

                if (!IsModel)
                {
                    db.Checks.Add(check);
                    db.SaveChanges();
                }
                else
                {
                    check.CheckId = 0;
                }

                var sells = new List<Sell>();

                foreach (var product in cart.GetAll())
                {
                    var sell = new Sell()
                    {
                        ProductId = product.ProductId,
                        Product = product
                    };

                    sells.Add(sell);

                    if (!IsModel)
                    {
                        db.Sells.Add(sell);
                    }

                    sum += product.Price;
                    product.Count--;

                }

                check.Price = sum;

                if (!IsModel)
                {
                    db.SaveChanges();
                }

                CartOut?.Invoke(this, check);
            }

            return sum;
        }

        public override string ToString()
        {
            return "Касса № " + Number;
        }
    }
}
