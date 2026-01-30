using UdemyNewMicroservice.Catalog.Api.Features.Categories;
using UdemyNewMicroservice.Catalog.Api.Repositories;

namespace UdemyNewMicroservice.Catalog.Api.Features.Courses
{
    public class Course : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal Price { get; set; } = default!;
        public string? Picture { get; set; }
        public DateTime CreatedDate { get; set; } = default!;

        public Guid CategoruId { get; set; }
        public Category Category { get; set; } = default!;

        public Feature Feature { get; set; } = default!;

        public Guid UserId { get; set; } = default!;
    }
}
