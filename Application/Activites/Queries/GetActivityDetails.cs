using System;
using System.Text.RegularExpressions;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activites.Queries;

public class GetActivityDetails
{

    public class Query : IRequest<Activity>
    {
        public required string Id { get; set; }
    }

    public class Handler(AppDbContext context) : IRequestHandler<Query, Activity>
    {
        public async Task<Activity> Handle(Query request, CancellationToken cancellationToken)
        {
            var activity = await context.Activities.FindAsync(new object?[] { request.Id }, cancellationToken: cancellationToken);
            if (activity == null)
            {
                throw new Exception("Activity Not Found");
            }
            return activity;
        }
    }


}
