﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IUserBalanceRepository
    {
        List<UserBalance> GetAll();
        UserBalance Get(int id);
        int Insert(UserBalance book);
        int Update(UserBalance book);
        int Delete(int id);
    }
}
