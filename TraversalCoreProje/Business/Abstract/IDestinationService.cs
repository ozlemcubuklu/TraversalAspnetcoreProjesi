using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDestinationService:IGenericService<Destination>
    {
        Destination GetDestinationwithGuide(int id);
        List<Destination> GetLast4DestinationList();

    }
}
