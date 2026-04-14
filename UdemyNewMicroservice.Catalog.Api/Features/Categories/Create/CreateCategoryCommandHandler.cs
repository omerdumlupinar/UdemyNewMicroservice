using MassTransit;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Net;
using UdemyNewMicroservice.Catalog.Api.Repositories;
using UdemyNewMicroservice.Shared;

namespace UdemyNewMicroservice.Catalog.Api.Features.Categories.Create
{
    public class CreateCategoryCommandHandler(AppDbContext context) : IRequestHandler<CreateCategoryCommand, ServiceResult<CreateCategoryResponse>>
    {
        public async Task<ServiceResult<CreateCategoryResponse>> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var existCategory = await context.Categories.AnyAsync(i => i.Name == request.Name, cancellationToken: cancellationToken);

            if (existCategory)
            {
                ServiceResult<CreateCategoryResponse>.Error("Category name alrealy exists", $"The category name '{request.Name}'", HttpStatusCode.BadRequest);
            }

            var category = new Category
            {
                Id = NewId.NextSequentialGuid(),
                Name = request.Name,
            };

            await context.AddAsync(category, cancellationToken);

            await context.SaveChangesAsync();

            return ServiceResult<CreateCategoryResponse>.SuccessAsCreated(new CreateCategoryResponse(category.Id.ToString()), "<empty>");
        }
    }
}
