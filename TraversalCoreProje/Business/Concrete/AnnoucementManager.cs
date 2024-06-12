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
    public class AnnoucementManager : IAnnoucementService
    {
        private readonly IAnnoucementDal _annoucementDal;

        public AnnoucementManager(IAnnoucementDal annoucementDal)
        {
            _annoucementDal = annoucementDal;
        }

        public void Delete(Annoucement t)
        {
            _annoucementDal.Delete(t);
        }

        public List<Annoucement> GetAll()
        {
           
            return _annoucementDal.GetAll();
        }

        public Annoucement GetById(int id)
        {
            return _annoucementDal.GetById(id);
        }

        public void Insert(Annoucement t)
        {
            _annoucementDal.Insert(t);
        }

        public void Update(Annoucement t)
        {
            _annoucementDal.Update(t);
        }
    }
}
