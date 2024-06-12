using Business.Abstract.UOW;
using Data.Abstract;
using Data.Uow;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.UOW
{
    public class AccountManager : IAccountService
    {
        private readonly IUowDal _uowDal;
        private readonly IAccountDal _accountDal;

        public AccountManager(IUowDal uowDal, IAccountDal accountDal)
        {
            _uowDal = uowDal;
            _accountDal = accountDal;
        }

  
        public Account GetById(int id)
        {
           return _accountDal.GetById(id);
        }

      

        public void Insert(Account t)
        {_accountDal.Insert(t);
            _uowDal.Save();
        }

        public void MultiUpdate(List<Account> t)
        {
            _accountDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public void Update(Account t)
        {
            _accountDal.Update(t);
            _uowDal.Save();
        }
    }
}
