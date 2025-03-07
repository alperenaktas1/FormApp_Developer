﻿using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        User Get(int id);
        void Add(User user);
        void Update(User user);
        void Delete(User user);
    }
}
