using QuickBuy.Domain.Entity;
using QuickBuy.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository
{
    public class Client
    {
        public Client() {
            var UserRepository = new UserRepository();
            var product = new Product();
            var user = new User();
            UserRepository.Create(user);
        }
    }
}
