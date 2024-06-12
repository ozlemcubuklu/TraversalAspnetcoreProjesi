using Data.Concrete;
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationHandler
    {
        private readonly Context _context;

        public UpdateDestinationHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.Id);
            if (values != null)
            {
                values.Price = command.Price;
                values.City = command.City;
                values.DayNight = command.DayNight;
                _context.SaveChanges(); 
            }
        }
    }
}
