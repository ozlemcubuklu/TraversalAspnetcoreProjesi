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
    public class EfCoreDestinationDal : GenericRepository<Destination>, IDestinationDal
    {
        private readonly Context _context;

        public EfCoreDestinationDal(Context context)
        {
            _context = context;
        }

        public Destination GetDestinationwithGuide(int id)
        {
            return _context.Destinations.Where(i=>i.Id==id).Include(x => x.Guide).First();
        }

        public List<Destination> GetLast4DestinationList()
        {
            var values = _context.Destinations.Take(4).OrderByDescending(x=>x.Id).ToList();
            return values;
        }
    }
}
