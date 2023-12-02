using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFNewsLetterDal : IGenericDal<NewsLetter>, INewsLetterDal
    {
        public void Delete(NewsLetter t)
        {
            throw new NotImplementedException();
        }

        public List<NewsLetter> GetList()
        {
            throw new NotImplementedException();
        }

        public void Insert(NewsLetter t)
        {
            throw new NotImplementedException();
        }

        public void Update(NewsLetter t)
        {
            throw new NotImplementedException();
        }
    }
}
