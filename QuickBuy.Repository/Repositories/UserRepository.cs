using QuickBuy.Domain.Contracts;
using QuickBuy.Domain.Entity;
using QuickBuy.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(QuickBuyContext quickBuyContext) : base(quickBuyContext) {

        }
    }
}
