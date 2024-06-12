using Data.Abstract;
using Data.Concrete.Repository;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete.EntityFramwork
{
    public class EfCoreContactUsDal : GenericRepository<ContactUs>, IContactUsDal
    {
        public void ContactUsStatusChangeToFalse(int id)
        {
            using var context = new Context();
            var values = context.ContactUses.Find(id);
            values.MessageStatus = false;
            context.SaveChanges();
        }

        public List<ContactUs> GetListByFalse()
        {
            using var context=new Context();
            return context.ContactUses.Where(i=>i.MessageStatus==false).ToList();
           
        }

        public List<ContactUs> GetListByTrue()
        {
            using var context = new Context();
            return context.ContactUses.Where(i => i.MessageStatus == true).ToList();

        }
    }
}
