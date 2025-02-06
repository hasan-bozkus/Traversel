namespace Traversal.CQRS.Commands.DestinationCommands
{
    public class RemoveDestinationCommand
    {
        public int id { get; set; }

        public RemoveDestinationCommand(int id)
        {
            this.id = id;
        }
    }
}
