using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Abstract
{
    public interface IContactUsDal:IGenericDal<ContactUs>
    {
        List<ContactUs> GetListByTrue();
        List<ContactUs> GetListByFalse();
        void ContactUsStatusChangeToFalse(int id);
    }
}
