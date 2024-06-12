using Data.Abstract;
using Data.Concrete.Repository;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete.EntityFramwork
{
    public class EfCoreGuideDal : GenericRepository<Guide>, IGuideDal
    {
        private readonly Context _context;

        public EfCoreGuideDal(Context context)
        {
            _context = context;
        }

        public void ChangeToStatus(int id)
        {
           
            var values = _context.Guides.Find(id);
            if (values != null)
            {
               values.Status= values.Status?false:true;
            }
            _context.SaveChanges();
        }
    }
}
