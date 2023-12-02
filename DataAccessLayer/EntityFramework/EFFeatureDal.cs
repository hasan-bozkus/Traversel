using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFFeatureDal : IGenericDal<Feature>, IFeatureDal
    {
        public void Delete(Feature t)
        {
            throw new NotImplementedException();
        }

        public List<Feature> GetList()
        {
            throw new NotImplementedException();
        }

        public void Insert(Feature t)
        {
            throw new NotImplementedException();
        }

        public void Update(Feature t)
        {
            throw new NotImplementedException();
        }
    }
}
