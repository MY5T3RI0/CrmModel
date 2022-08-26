using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model.Tests
{
    [TestClass()]
    public class CashDeskTests
    {
        [TestMethod()]
        public void CashDeskTest()
        {
            //arrange
            var Seller = new Seller()
            {
                SellerId = 1,
                Name = "testseller"
            };

            var Customer1 = new Customer()
            {
                CustomerId = 1,
                Name = "testuser1"
            };

            var Customer2 = new Customer()
            {
                CustomerId = 2,
                Name = "testuser2"
            };

            var Product1 = new Product()
            {
                ProductId = 1,
                Name = "Колбаса",
                Count = 1000,
                Price = 300
            };

            var Product2 = new Product()
            {
                ProductId = 2,
                Name = "Хлеб",
                Count = 100,
                Price = 50
            };

            var Cart1 = new Cart(Customer1)
            {
                Number = 1
            };
            var Cart2 = new Cart(Customer2)
            {
                Number = 1
            }; ;

            var cashdesk = new CashDesk(1, Seller, null)
            {
                MaxQueue = 10
            };

            Cart1.Add(Product1);
            Cart1.Add(Product1);
            Cart1.Add(Product2);

            Cart2.Add(Product1);
            Cart2.Add(Product2);
            Cart2.Add(Product2);

            var expectedSum1 = 650.00;
            var expectedSum2 = 400.00;

            //act
            cashdesk.Enqueue(Cart1);
            cashdesk.Enqueue(Cart2);
            var cart1ActualResult = cashdesk.Dequeue();
            var cart2ActualResult = cashdesk.Dequeue();

            //assert
            Assert.AreEqual(cart1ActualResult, Convert.ToDecimal(expectedSum1));
            Assert.AreEqual(cart2ActualResult, Convert.ToDecimal(expectedSum2));
            Assert.AreEqual(Product1.Count, 997);
            Assert.AreEqual(Product2.Count, 97);
        }
    }
}