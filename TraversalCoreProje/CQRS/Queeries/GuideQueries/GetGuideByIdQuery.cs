using MediatR;
using TraversalCoreProje.CQRS.Results.GuideResults;

namespace TraversalCoreProje.CQRS.Queeries.GuideQueries
{
    public class GetGuideByIdQuery:IRequest<GetGuideByIdQueryResult>
    { 
        public int Id { get; set; }

        public GetGuideByIdQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
