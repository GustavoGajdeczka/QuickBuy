using QuickBuy.Domain.Contracts;
using QuickBuy.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository() {

        }
    }
}
