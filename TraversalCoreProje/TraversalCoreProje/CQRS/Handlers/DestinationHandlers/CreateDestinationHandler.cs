using Data.Concrete;
using Entity;
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationHandler
    {
        private readonly Context _context;

        public CreateDestinationHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateDestinationCommand command) { 
        var values=new Destination() { 
            Capasity = command.Capasity,
            City=command.City,
            DayNight=command.DayNight,
            Status=true,
            Price=command.Price
        };
            _context.Destinations.Add(values);
            _context.SaveChanges();
        }
    }
}
