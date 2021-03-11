using InventoryManagementSystem.Repository;
using InventoryManagementSystem.Domain;
using InventoryManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagementSystem.Domain
{
    public class ProcessOrderRepo : IProcessOrderRepository
    {
        public bool ProcessOrder(string productId, int qty)
        {
            IInventoryRepository IInventoryRepo = new InventoryRepo();

            if (IInventoryRepo.CheckInventory(productId, qty))
            {
                IPaymentRepository IPaymentRepo = new PaymentRepo();
                if (IPaymentRepo.ChargePayment("1234", 23))
                {
                    ISendMailRepository ISendEmailRepo = new SendMailRepo();
                    ISendEmailRepo.SendEmail();
                    return true;
                }
            }

            return false;

        }
    }
}