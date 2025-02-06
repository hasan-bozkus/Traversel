﻿using DataAccessLayer.Concrete;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Traversal.CQRS.Queries.GuideQueries;
using Traversal.CQRS.Results.GuideResults;

namespace Traversal.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIDQueryHandler : IRequestHandler<GetGuideByIDQuery, GetGuideByIDQueryResult>
    {
        private readonly Context _context;

        public GetGuideByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIDQueryResult> Handle(GetGuideByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.id);
            return new GetGuideByIDQueryResult
            {
                Description = values.Description,
                GuideID = values.GuideID,
                Name = values.Name
            };
        }
    }
}
