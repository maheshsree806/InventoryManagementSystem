using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Repository
{
    public interface IProcessOrderRepository
    {
        bool ProcessOrder(string productId, int qty);
    }
}
