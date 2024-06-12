using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Abstract
{
    public interface IReservationDal:IGenericDal<Reservation>
    {
        List<Reservation> GetListReservationsByWaitApproval(int id);
        List<Reservation> GetListReservationsByAccepted(int id);
        List<Reservation> GetListReservationsByPrevious(int id);


    }
}
