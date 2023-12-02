using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFTestimonialDal : IGenericDal<Testimonial>, ITestimonialDal
    {
        public void Delete(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> GetList()
        {
            throw new NotImplementedException();
        }

        public void Insert(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void Update(Testimonial t)
        {
            throw new NotImplementedException();
        }
    }
}
