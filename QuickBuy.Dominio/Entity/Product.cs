﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entity
{
    public class Product : Entity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Description { get; set; }
        public decimal Preco { get; set; }

        public override void Validate() {
            throw new NotImplementedException();
        }
    }
}