namespace TraversalCoreProje.CQRS.Commands.DestinationCommads
{
    public class UpdateDestinationCommand
    {
        public int Id { get; set; }
        public string city { get; set; }
        public string daynight { get; set; }
        public double price { get; set; }
    }
}
