using MediatR;
using Traversal.CQRS.Results.GuideResults;

namespace Traversal.CQRS.Queries.GuideQueries
{
    public class GetGuideByIDQuery : IRequest<GetGuideByIDQueryResult>
    {
        public int id { get; set; }

        public GetGuideByIDQuery(int id)
        {
            this.id = id;
        }
    }
}
