using FastEndpoints;
using FastEndpointsDemo.SignalR;
using MapperlyTestForMapping.DTO;
using MapperlyTestForMapping.MappingProfiles;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.SignalR;

namespace FastEndpointsDemo.Endpoints
{
    public class Create : Endpoint<BegivenhederDto, Results<Ok<BegivenhederDto>, NotFound, ProblemDetails>>
    {
        private readonly IHubContext<OrderHub> _messageHubContext;

        public Create(IHubContext<OrderHub> messageHubContext)
        {
            _messageHubContext = messageHubContext;
        }
        public override void Configure()
        {
            Post("/api/create");
            Summary(s =>
            {
                s.Summary = "create begivenheder";
                s.Responses[200] = "OK, Begivenheder has been successfully created";
                s.RequestParam(r => r.Stoftype, "sections as array");
            });
            AllowAnonymous();

        }

        public override async Task<Results<Ok<BegivenhederDto>, NotFound, ProblemDetails>> ExecuteAsync(BegivenhederDto req, CancellationToken ct)
        {
            await Task.CompletedTask;

            if (req is null)
            {
                AddError("nothing to create");
                return new ProblemDetails(ValidationFailures);
            }

            MapperlyTestForMapping.Models.Begivenheder? toEntity = BegivenhederMapper.ToBegivenheder(req);

            BegivenhederDto begivenhederDto = BegivenhederMapper.ToBegivenhederDto(toEntity);

            await _messageHubContext.Clients.All.SendAsync("PushBegivenhederToClients", begivenhederDto, ct);

            return TypedResults.Ok(begivenhederDto);
        }
    }
}
