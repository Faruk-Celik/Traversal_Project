using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using TraversalCoreProje.CQRS.Commands.DestinationCommads;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    { 
        private readonly Context _context;

        public CreateDestinationCommandHandler(Context context)
        {
            _context = context;
        } 

        public void Handle(CreateDestinationCommand command)  
        {
            _context.Destinations.Add(new Destination
            {
                City = command.city,
                Price = command.price,
                DayNight = command.daynight,
                Capacity = command.capacity,
                Status = true
            });  
            _context.SaveChanges();
        }
    }
}
