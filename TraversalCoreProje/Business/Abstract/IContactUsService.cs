using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IContactUsService:IGenericService<ContactUs>
    {
        List<ContactUs> GetListByTrue();
        List<ContactUs> GetListByFalse();
        void ContactUsStatusChangeToFalse(int id);
    }
}
