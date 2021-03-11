using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagementSystem.Models
{
    public class ProcessOrderModel
    {
        public string Id { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}