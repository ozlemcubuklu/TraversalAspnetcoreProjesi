using Business.Abstract;
using Entity;
using Data.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationdal;

        public ReservationManager(IReservationDal reservationdal)
        {
            _reservationdal = reservationdal;
        }

        public void Delete(Reservation t)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetAll()
        {
            throw new NotImplementedException();
        }

        public Reservation GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListReservationsByAccepted(int id)
        {
            return _reservationdal.GetListReservationsByAccepted(id);
        }

        public List<Reservation> GetListReservationsByPrevious(int id)
        {
            return _reservationdal.GetListReservationsByPrevious(id);
        }

        public List<Reservation> GetListReservationsByWaitApproval(int id)
        {
            return _reservationdal.GetListReservationsByWaitApproval(id);
        }

        public void Insert(Reservation t)
        {
           _reservationdal.Insert(t);
        }

        public void Update(Reservation t)
        {
            throw new NotImplementedException();
        }
    }
}
