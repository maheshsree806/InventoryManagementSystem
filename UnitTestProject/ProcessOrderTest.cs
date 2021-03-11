using InventoryManagementSystem.Domain;
using InventoryManagementSystem.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class ProcessOrderTest
    {
        [TestMethod]
        public void ProcessOrderSuccessfully()
        {
            IProcessOrderRepository processOrderRepository = new ProcessOrderRepo();
            var result = processOrderRepository.ProcessOrder("4", 8);

            Assert.AreEqual(true, result);
               
        }

        [TestMethod]
        public void QuantityIsNotAvailableInStore()
        {
            IProcessOrderRepository processOrderRepository = new ProcessOrderRepo();
            var result = processOrderRepository.ProcessOrder("4", 9);

            Assert.AreEqual(false, result);

        }
    }
}
