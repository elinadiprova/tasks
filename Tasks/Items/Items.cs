using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public class Item
    {
        public int ItemCode { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        public Item(int itemCode, string description, int quantity) 
        {
            ItemCode = itemCode;
            Description = description;
            Quantity = quantity;
        }
    }
}
