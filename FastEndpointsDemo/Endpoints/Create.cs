using FastEndpoints;
using MapperlyTestForMapping.DTO;
using MapperlyTestForMapping.MappingProfiles;
using Microsoft.AspNetCore.Http.HttpResults;

namespace FastEndpointsDemo.Endpoints
{
    public class Create : Endpoint<BegivenhederDto, Results<Ok<ResponseDto>, NotFound, ProblemDetails>>
    {
        public override void Configure()
        {
            Post("/api/create");
            AllowAnonymous();

        }

        public override async Task<Results<Ok<ResponseDto>, NotFound, ProblemDetails>> ExecuteAsync(BegivenhederDto req, CancellationToken ct)
        {
            await Task.CompletedTask;

            if (req is null)
            {
                AddError("nothing to create");
                return new ProblemDetails(ValidationFailures);
            }

            MapperlyTestForMapping.Models.Begivenheder? toEntity = BegivenhederMapper.ToBegivenheder(req);

            return TypedResults.Ok(new ResponseDto(toEntity is not null));
        }
    }
}
