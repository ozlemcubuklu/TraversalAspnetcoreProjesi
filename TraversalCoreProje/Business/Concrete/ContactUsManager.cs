using Business.Abstract;
using Data.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ContactUsManager : IContactUsService
    {
        IContactUsDal _contactusdal;

        public ContactUsManager(IContactUsDal contactusdal)
        {
            _contactusdal = contactusdal;
        }

        public void ContactUsStatusChangeToFalse(int id)
        {
           _contactusdal.ContactUsStatusChangeToFalse(id);
        }

        public void Delete(ContactUs t)
        {
           _contactusdal.Delete(t);
        }

        public List<ContactUs> GetAll()
        {
            return _contactusdal.GetAll();
        }

        public ContactUs GetById(int id)
        {
           return _contactusdal.GetById(id);
        }

        public List<ContactUs> GetListByFalse()
        {
            return _contactusdal.GetListByFalse();
        }

        public List<ContactUs> GetListByTrue()
        {
            return _contactusdal.GetListByTrue();
        }

        public void Insert(ContactUs t)
        {
         _contactusdal.Insert(t);
        }

        public void Update(ContactUs t)
        {
          _contactusdal.Update(t);
        }
    }
}
