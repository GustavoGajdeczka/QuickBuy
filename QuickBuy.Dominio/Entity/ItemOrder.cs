﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace QuickBuy.Domain.Entity
{
    public class ItemOrder : Entity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public override void Validate() {
            throw new NotImplementedException();
        }
    }
}
