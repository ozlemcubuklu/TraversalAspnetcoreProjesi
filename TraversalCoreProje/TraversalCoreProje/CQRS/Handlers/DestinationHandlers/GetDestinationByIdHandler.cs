using Data.Concrete;
using TraversalCoreProje.CQRS.Queries;
using TraversalCoreProje.CQRS.Results;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdHandler
    {
        private readonly Context _context;

        public GetDestinationByIdHandler(Context context)
        {
            _context = context;
        }


        public GetDestinationByIdQueryResult Handle(GetDestinationByIdQuery query)
        {
            var values = _context.Destinations.Find(query.Id);
            return new GetDestinationByIdQueryResult() { Id=values.Id,City=values.City,DayNight=values.DayNight,Price=values.Price };
        }
    }
}
