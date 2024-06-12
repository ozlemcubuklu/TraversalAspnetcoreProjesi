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
    public class SubAboutManager:ISubAboutService
    {
        ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public void Delete(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> GetAll()
        {
            return _subAboutDal.GetAll();
        }

        public SubAbout GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public void Update(SubAbout t)
        {
            throw new NotImplementedException();
        }
    }
}
