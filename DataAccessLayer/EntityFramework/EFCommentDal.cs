using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetListCommentWithDestinaiton()
        {
            using (var context = new Context())
            {
                var values = context.Comments.Include(x => x.Destination).ToList();
                return values;
            }
        }

        public List<Comment> GetListCommentWithDestinationAndUser(int id)
        {
            using(var context = new Context())
            {
                return context.Comments.Include(x => x.AppUser).Where(y => y.DestinationID == id).ToList();
            }
        }
    }
}
