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
    public class GuideManager : IGuideService
    {
        IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void ChangeToStatus(int id)
        {
            _guideDal.ChangeToStatus(id);
        }

        public void Delete(Guide t)
        {
            _guideDal.Delete(t);
        }

        public List<Guide> GetAll()
        {
            return _guideDal.GetAll();
        }

        public Guide GetById(int id)
        {
           return _guideDal.GetById(id);
        }

        public void Insert(Guide t)
        {
           _guideDal.Insert(t);
        }

        public void Update(Guide t)
        {
           _guideDal.Update(t);
        }
    }
}
