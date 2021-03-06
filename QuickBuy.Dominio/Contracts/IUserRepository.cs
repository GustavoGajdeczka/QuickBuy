﻿using QuickBuy.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Contracts
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        User _Get(string email, string password);

        User _Get(string email);
    }
}
