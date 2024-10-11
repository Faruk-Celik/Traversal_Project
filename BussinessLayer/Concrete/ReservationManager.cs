using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public List<Reservation> GetListApprovalReservation(int id)
        {
           return _reservationDal.GetlistByFilter(x=>x.AppUser.Id == id && x.status == "Onay Bekliyor");
        }

        public void TAdd(Reservation t)
        { 
            _reservationDal.Insert(t);
        }

        public void TDelete(int id)
        {
            _reservationDal.Delete(id);
        }

        public Reservation TGetById(int id)
        {
           return _reservationDal.GetById(id);
        }

        public List<Reservation> TGetList()
        {
            throw new NotImplementedException();
        }

        public List<Reservation> TGetListWithReservationByAccepted(int id)
        {
           return _reservationDal.GetListWithReservationByAccepted(id);
        }

        public List<Reservation> TGetListWithReservationByPrevious(int id)
        {
            return _reservationDal.GetListWithReservationByPrevious(id);
        }

        public List<Reservation> TGetListWithReservationByWaitApproval(int id)
        {
            return _reservationDal.GetListWithReservationByWaitApproval(id);
        }

        public void TUpdate(Reservation t)
        { 
            _reservationDal.Update(t);
        }
    }
}
