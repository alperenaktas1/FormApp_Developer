using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Post : IEntity
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }

        public User user { get; set; }
        public int UserId { get; set; }
    }
}
