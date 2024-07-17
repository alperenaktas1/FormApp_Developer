using Businness.Abstract;
using DB.Abstract;
using DB.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal userDal;
        public UserManager(IUserDal userDal)
        {
            this.userDal = userDal;
        }

        public void Add(User user)
        {
           userDal.Add(user);
        }

        public void Delete(User user)
        {
            userDal.Delete(user);
        }

        public User Get(int id)
        {
            return userDal.Get(x=>x.Id==id);
        }

        public List<User> GetAll()
        {
            return userDal.GetAll();
        }

        public void Update(User user)
        {
            userDal.Update(user);
        }
    }
}
