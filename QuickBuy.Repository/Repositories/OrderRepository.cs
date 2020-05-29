using QuickBuy.Domain.Contracts;
using QuickBuy.Domain.Entity;
using QuickBuy.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(QuickBuyContext quickBuyContext) : base(quickBuyContext) {
        }
    }
}
