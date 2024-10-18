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
	public class ReservationManager : IReservationService
	{
		IReservationDal _ReservationDal;

		public ReservationManager(IReservationDal reservationDal)
		{
			_ReservationDal = reservationDal;
		}

        public List<Reservetion> GetListApprovalReservation(int id)
        {
			return _ReservationDal.GetListByFilter(x => x.AppUserID == id && x.Status == "Onay Bekliyor");
        }

        public void TAdd(Reservetion t)
		{
			_ReservationDal.Insert(t);
		}

		public void TDelete(Reservetion t)
		{
			_ReservationDal.Delete(t);
		}

		public Reservetion TGetByID(int id)
		{
			return  _ReservationDal.GetByID(id);
		}

		public List<Reservetion> TGetList()
		{
			return _ReservationDal.GetList();
		}

		public void TUpdate(Reservetion t)
		{
			_ReservationDal.Update(t);
		}
	}
}
