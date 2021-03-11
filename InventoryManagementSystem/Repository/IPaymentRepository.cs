using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Repository
{
    public interface IPaymentRepository
    {
        bool ChargePayment(string creditCardNumber, decimal amount);
    }
}
