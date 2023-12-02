using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFSubAboutDal : IGenericDal<SubAbout>, ISubAboutDal
    {
        public void Delete(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> GetList()
        {
            throw new NotImplementedException();
        }

        public void Insert(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public void Update(SubAbout t)
        {
            throw new NotImplementedException();
        }
    }
}
