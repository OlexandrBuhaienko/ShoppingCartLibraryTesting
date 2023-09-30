using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLibrary
{
    public class Item
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public Item(string name = "", int quantity = 0)
        {
            Name = name;
            Quantity = quantity;
        }
    }
}
