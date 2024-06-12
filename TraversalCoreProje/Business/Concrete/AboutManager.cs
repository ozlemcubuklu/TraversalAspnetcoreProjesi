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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutdal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutdal = aboutDal;
        }
        public void Delete(About t)
        {
            _aboutdal.Delete(t);
        }

        public List<About> GetAll()
        {
          return  _aboutdal.GetAll();
        }

        public About GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(About t)
        {
            _aboutdal.Insert(t);
        }

        public void Update(About t)
        {
            _aboutdal.Update(t);
        }
    }
}
