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
    public class DestinationManager : IDestinationService
    {
        private readonly IDestinationDal _destination;
        public DestinationManager(IDestinationDal destination)
        {
            _destination = destination;       
        }

        public void Delete(Destination t)
        {
            _destination.Delete(t);
        }

        public List<Destination> GetAll()
        {
           return _destination.GetAll();
        }

        public Destination GetById(int id)
        {
           return _destination.GetById(id);
        }

        public Destination GetDestinationwithGuide(int id)
        {
           return _destination.GetDestinationwithGuide(id);
        }

        public List<Destination> GetLast4DestinationList()
        {
           return _destination.GetLast4DestinationList();
        }

        public void Insert(Destination t)
        {
             _destination.Insert(t);
        }

        public void Update(Destination t)
        {
            _destination.Update(t);
        }
    }
}
