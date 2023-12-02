using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFContactDal : IGenericDal<Contact>, IContactDal
    {
        public void Delete(Contact t)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetList()
        {
            throw new NotImplementedException();
        }

        public void Insert(Contact t)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
