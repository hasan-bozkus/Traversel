using DataAccessLayer.Concrete;
using Traversal.CQRS.Commands.DestinationCommands;
using EntityLayer.Concrete;

namespace Traversal.CQRS.Handlers.DestinationHandlers
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
                City = command.City,
                Capacity = command.Capacity,
                DayNight = command.DayNight,
                Price = command.Price,
                status = true
            });
            _context.SaveChanges();
        }
    }
}
