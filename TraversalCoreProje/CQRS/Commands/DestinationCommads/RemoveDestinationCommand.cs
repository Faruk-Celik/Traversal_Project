namespace TraversalCoreProje.CQRS.Commands.DestinationCommads
{
    public class RemoveDestinationCommand
    { 
        public int Id { get; set; }

        public RemoveDestinationCommand(int id)
        {
            Id = id;
        }
    }
}
