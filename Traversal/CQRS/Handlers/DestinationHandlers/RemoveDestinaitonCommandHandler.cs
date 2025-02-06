using DataAccessLayer.Concrete;
using Traversal.CQRS.Commands.DestinationCommands;

namespace Traversal.CQRS.Handlers.DestinationHandlers
{
    public class RemoveDestinaitonCommandHandler
    {
        private readonly Context _context;

        public RemoveDestinaitonCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.id);
            _context.Destinations.Remove(values);
            _context.SaveChanges();
        }
    }
}
