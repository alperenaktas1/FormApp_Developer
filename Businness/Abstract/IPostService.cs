using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Abstract
{
    public interface IPostService
    {
        List<Post> GetAll();
        List<Post> GetByDescription(string description);
        Post Get(int id);
        void Add(Post post);
        void Update(Post post);
        void Delete(Post post);
    }
}
