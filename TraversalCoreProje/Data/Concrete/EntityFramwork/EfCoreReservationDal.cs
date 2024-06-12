using Data.Abstract;
using Data.Concrete.Repository;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete.EntityFramwork
{
    public class EfCoreReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        private readonly Context _context;

        public EfCoreReservationDal(Context context)
        {
            _context = context;
        }

        public List<Reservation> GetListReservationsByAccepted(int id)
        {
           
                return _context.Reservations.Include(x=>x.AppUser).Include(x => x.Destination).Where(x=>x.AppUserId==id && x.Status=="Onaylandı").ToList();
            
        }

        public List<Reservation> GetListReservationsByPrevious(int id)
        {
            
                return _context.Reservations.Include(x => x.Destination).Where(x => x.AppUserId == id && x.Status == "Geçmiş").ToList();
            
        }

        public List<Reservation> GetListReservationsByWaitApproval(int id)
        {
           
                return _context.Reservations.Include(x => x.Destination).Where(x => x.AppUserId == id && x.Status == "Onay Bekliyor").ToList();
            
        }
    }
}
