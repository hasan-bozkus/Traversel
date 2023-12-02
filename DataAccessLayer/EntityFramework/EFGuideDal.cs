using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFGuideDal : IGenericDal<Guide>, IGuideDal
    {
        public void Delete(Guide t)
        {
            throw new NotImplementedException();
        }

        public List<Guide> GetList()
        {
            throw new NotImplementedException();
        }

        public void Insert(Guide t)
        {
            throw new NotImplementedException();
        }

        public void Update(Guide t)
        {
            throw new NotImplementedException();
        }
    }
}
