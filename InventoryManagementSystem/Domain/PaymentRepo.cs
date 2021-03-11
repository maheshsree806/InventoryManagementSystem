using InventoryManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagementSystem.Domain
{
    public class PaymentRepo : IPaymentRepository
    {
        public bool ChargePayment(string creditCardNumber, decimal amount)
        {
            return true;
        }
    }
}