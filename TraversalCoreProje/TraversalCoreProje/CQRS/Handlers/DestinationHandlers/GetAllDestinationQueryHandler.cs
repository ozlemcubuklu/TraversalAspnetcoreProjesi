using Data.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using TraversalCoreProje.CQRS.Results;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{

    public class GetAllDestinationQueryHandler
    {   private readonly Context _context;

        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }




        public List<GetAllDestinationQueryResult> Handle() { 
        
        var values=_context.Destinations.Select(x=>new GetAllDestinationQueryResult()
        {
            Id = x.Id,
            Capasity = x.Capasity,
            Price = x.Price,
            DayNight = x.DayNight,
            City = x.City
        }).AsNoTracking().ToList();
            return values;
        }
    }
}
