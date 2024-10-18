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
    public class EFReservationDal : GenericRepository<Reservetion>, IReservationDal
    {
        public List<Reservetion> GetListWithReservationByAccepted(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservetion> GetListWithReservationByPrevious(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservetion> GetListWithReservationByWithApproval(int id)
        {
            //using (var context = new Context())
            //{
            //    return context.Reservetions.Include(x => x.Destination).Where();
            //};
            throw new NotImplementedException();
        }
    }
}
