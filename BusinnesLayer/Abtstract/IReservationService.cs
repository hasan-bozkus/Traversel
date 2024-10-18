using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Abtstract
{
	public interface IReservationService : IGenericService<Reservetion>
	{
        List<Reservetion> TGetListWithReservationByWithApproval(int id);
        List<Reservetion> TGetListWithReservationByAccepted(int id);
        List<Reservetion> TGetListWithReservationByPrevious(int id);
    }
}
