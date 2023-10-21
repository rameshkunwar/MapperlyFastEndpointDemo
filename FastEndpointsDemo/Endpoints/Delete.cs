using FastEndpoints;
using Microsoft.AspNetCore.Http.HttpResults;

namespace FastEndpointsDemo.Endpoints
{
    public class Delete : Endpoint<DeleteRequestDto, Results<Ok<DeleteResponseDto>, NotFound, ProblemDetails>>
    {
        public override void Configure()
        {
            Delete("/api/delete/{id}");
            AllowAnonymous();

        }

        public override async Task<Results<Ok<DeleteResponseDto>, NotFound, ProblemDetails>> ExecuteAsync(DeleteRequestDto req, CancellationToken ct)
        {
            await Task.CompletedTask;

            //Guid id = Query<Guid>("id");

            if (req.Id == Guid.Empty)
            {
                AddError($"Id cannot be empty. Got Id = {req.Id}");
                return new ProblemDetails(ValidationFailures);
            }

            bool isSuccess = Guid.Parse("d202f02d-f990-4c6e-a3a0-34293a9ea406") == req.Id;

            return TypedResults.Ok(new DeleteResponseDto(Success: isSuccess));
        }
    }

    public record DeleteRequestDto(Guid Id);
    public record DeleteResponseDto(bool Success);
}
