using MediatR;
using System.Collections.Generic;
using TraversalCoreProje.CQRS.Results.GuideResults;

namespace TraversalCoreProje.CQRS.Queeries.GuideQueries
{
    public class GetAllGuideQuery:IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
