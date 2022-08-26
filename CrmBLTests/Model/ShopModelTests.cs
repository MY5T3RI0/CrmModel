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
    public class ShopModelTests
    {
        [TestMethod()]
        public void StartTest()
        {
            var shopModel = new ShopModel();
            shopModel.Start();
        }
    }
}