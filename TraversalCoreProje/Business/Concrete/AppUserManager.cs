using Business.Abstract;
using Data.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _dal;

        public AppUserManager(IAppUserDal dal)
        {
            _dal = dal;
        }

        public void Delete(AppUser t)
        {
           _dal.Delete(t);
        }

        public List<AppUser> GetAll()
        {
           return _dal.GetAll();
        }

        public AppUser GetById(int id)
        {
           return _dal.GetById(id);
        }

        public List<AppUser> GetListByFilter(Expression<Func<AppUser, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(AppUser t)
        {
          _dal.Insert(t);
        }

        public void Update(AppUser t)
        {
          _dal.Update(t);
        }
    }
}
