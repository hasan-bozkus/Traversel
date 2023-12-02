using BusinnesLayer.Abtstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _abutDal;

        public AboutManager(IAboutDal abutDal)
        {
            _abutDal = abutDal;
        }

        public void TAdd(About t)
        {
            _abutDal.Insert(t);
        }

        public void TDelete(About t)
        {
            _abutDal.Delete(t);
        }

        public About TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> TGetList()
        {
            return _abutDal.GetList();
        }

        public void TUpdate(About t)
        {
            _abutDal.Update(t);
        }
    }
}
