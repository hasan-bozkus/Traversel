using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface IReservationDal : IGenericDal<Reservetion>
	{
		List<Reservetion> GetListWithReservationByWithApproval(int id);
		List<Reservetion> GetListWithReservationByAccepted(int id);
		List<Reservetion> GetListWithReservationByPrevious(int id);
	}
}
