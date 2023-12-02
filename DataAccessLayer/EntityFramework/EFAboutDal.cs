using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFAboutDal : IGenericDal<About>, IAboutDal
    {
        public void Delete(About t)
        {
            throw new NotImplementedException();
        }

        public List<About> GetList()
        {
            throw new NotImplementedException();
        }

        public void Insert(About t)
        {
            throw new NotImplementedException();
        }

        public void Update(About t)
        {
            throw new NotImplementedException();
        }
    }
}
