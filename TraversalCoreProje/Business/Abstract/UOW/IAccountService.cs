using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.UOW
{
    public interface IAccountService:IGenericUowService<Account>
    {
    }
}
