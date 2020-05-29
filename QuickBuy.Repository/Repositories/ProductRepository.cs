using QuickBuy.Domain.Contracts;
using QuickBuy.Domain.Entity;
using QuickBuy.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(QuickBuyContext quickBuyContext) : base(quickBuyContext) {
        }
    }
}
