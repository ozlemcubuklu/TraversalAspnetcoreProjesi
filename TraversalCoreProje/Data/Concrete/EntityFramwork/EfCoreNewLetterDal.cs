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
    public class EfCoreNewLetterDal:GenericRepository<NewLetter>,INewLetterDal
    {
    }
}
