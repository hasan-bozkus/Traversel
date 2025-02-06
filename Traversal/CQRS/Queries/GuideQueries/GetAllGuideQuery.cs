using Traversal.CQRS.Results.GuideResults;
using MediatR;
using System.Collections.Generic;

namespace Traversal.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery : IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
