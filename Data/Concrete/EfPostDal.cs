using DB.Abstract;
using DB.Context;
using DB.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DB.Concrete
{
    public class EfPostDal : EfEntityRepositoryBase<Post,FormAppDBContext> , IPostDal
    {
        
    }
}
