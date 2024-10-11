namespace TraversalCoreProje.CQRS.Results.DestinationResults
{
    public class GetDestinationByIdQueryResult
    { 
        public int Id { get; set; } 
        public string city { get; set; } 
        public string daynight { get; set; } 
        public double price { get; set; }
    }
}
