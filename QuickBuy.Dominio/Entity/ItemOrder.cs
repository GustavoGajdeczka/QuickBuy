using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entity
{
    public class ItemOrder
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }



    }
}
