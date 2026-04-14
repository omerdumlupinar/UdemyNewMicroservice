using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace UdemyNewMicroservice.Catalog.Api.Features.Categories.Create
{
    public static class CreateCategoryEndpoint
    {
        public static RouteGroupBuilder CreateCategoryGroupItemEndpoint(this RouteGroupBuilder routeGroupBuilder)
        {
            routeGroupBuilder.MapPost("/Add", async (CreateCategoryCommand command, IMediator mediator) =>
            {
                var result = await mediator.Send(command);

                return new ObjectResult(result)
                {
                    StatusCode = result.Status.GetHashCode(),
                };

            });

            return routeGroupBuilder;
        }
    }
}
