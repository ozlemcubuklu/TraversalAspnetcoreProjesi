
using Data.Concrete;
using System.ComponentModel.DataAnnotations;
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class DeleteDestinationHandler
    {
        private readonly Context _context;

        public DeleteDestinationHandler(Context context)
        {
            _context = context;
        }


        public void Handle(DeleteDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.Id);
            if (values != null)
            {
                _context.Destinations.Remove(values);
                _context.SaveChanges();
            }



        }
    }
}
