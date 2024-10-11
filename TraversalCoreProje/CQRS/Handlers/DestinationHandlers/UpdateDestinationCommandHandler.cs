using DataAccessLayer.Concrete;
using TraversalCoreProje.CQRS.Commands.DestinationCommads;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;

        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateDestinationCommand command)
        {
            var values=_context.Destinations.Find(command.Id);
            values.City = command.city; 
            values.DayNight=command.daynight; 
            values.Price = command.price; 
            _context.SaveChanges();

        }
    }
}
