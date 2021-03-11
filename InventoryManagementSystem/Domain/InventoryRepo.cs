using InventoryManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace InventoryManagementSystem.Domain
{
    public class InventoryRepo : IInventoryRepository
    {
        IDictionary<string, int> ProductStoreValues = new Dictionary<string, int>();
        public InventoryRepo()
        {
            AddStoreValues();
        }

        private void AddStoreValues()
        {
            for(int i=0; i <=10; i++)
            {
                ProductStoreValues.Add(new KeyValuePair<string, int>(i.ToString(), i*2));
            }
        }

        public bool CheckInventory(string productId, int qty)
        {
            return ProductStoreValues.ToList().Where(q=> q.Key == productId && q.Value == qty).Any();
        }

       
    }
}