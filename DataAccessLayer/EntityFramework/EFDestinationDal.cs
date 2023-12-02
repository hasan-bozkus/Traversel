using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFDestinationDal : IGenericDal<Destination>, IDestinationDal
    {
        public void Delete(Destination t)
        {
            throw new NotImplementedException();
        }

        public List<Destination> GetList()
        {
            throw new NotImplementedException();
        }

        public void Insert(Destination t)
        {
            throw new NotImplementedException();
        }

        public void Update(Destination t)
        {
            throw new NotImplementedException();
        }
    }
}
