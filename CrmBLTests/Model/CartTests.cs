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
    public class CartTests
    {
        [TestMethod()]
        public void CartTest()
        {
            //arrange
            var Customer = new Customer()
            {
                CustomerId = 1,
                Name = "testuser"
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

            var Cart = new Cart(Customer);

            var expectedResult = new List<Product>()
            {
                Product1, Product1, Product2
            };

            //act
            Cart.Add(Product1);
            Cart.Add(Product1);
            Cart.Add(Product2);

            //assert
            for (int i = 0; i < Cart.GetAll().Count; i++)
            {
                Assert.AreEqual(Cart.GetAll()[i], expectedResult[i]);
            }
            
        }

    }
}