using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Abstract
{
    public interface IDestinationDal:IGenericDal<Destination>
    {

        Destination GetDestinationwithGuide(int id); 
        List<Destination> GetLast4DestinationList();
    }
}
