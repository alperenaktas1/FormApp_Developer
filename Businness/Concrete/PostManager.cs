using Businness.Abstract;
using DB.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Concrete
{
    public class PostManager : IPostService
    {
        IPostDal postDal;
        public PostManager(IPostDal postDal)
        {
            this.postDal = postDal;
        }

        public void Add(Post post)
        {
            postDal.Add(post);
        }

        public void Delete(Post post)
        {
            postDal.Delete(post);
        }

        public Post Get(int id)
        {
            return postDal.Get(x => x.Id == id);
        }

        public List<Post> GetAll()
        {
            return postDal.GetAll();
        }

        public List<Post> GetByDescription(string description)
        {
            return postDal.GetAll(x => x.Description.Contains(description));
        }

        public void Update(Post post)
        {
            postDal.Update(post);
        }
    }
}
