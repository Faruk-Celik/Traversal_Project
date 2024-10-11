namespace TraversalCoreProje.CQRS.Commands.DestinationCommads
{
    public class CreateDestinationCommand
    {
        public string city { get; set; }
        public string daynight { get; set; }
        public double price { get; set; }
        public int capacity { get; set; }
        public bool status { get; set; }
    }
}
