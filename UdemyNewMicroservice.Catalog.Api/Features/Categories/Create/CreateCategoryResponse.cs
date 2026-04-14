using MediatR;
using UdemyNewMicroservice.Shared;

namespace UdemyNewMicroservice.Catalog.Api.Features.Categories.Create
{
    public record CreateCategoryResponse(Guid Name);
}
