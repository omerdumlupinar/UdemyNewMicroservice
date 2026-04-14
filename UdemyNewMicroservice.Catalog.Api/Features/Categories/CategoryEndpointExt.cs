using UdemyNewMicroservice.Catalog.Api.Features.Categories.Create;

namespace UdemyNewMicroservice.Catalog.Api.Features.Categories
{
    public static class CategoryEndpointExt
    {
        public static void AddCategoryGroupEndpointExt(this WebApplication webApplication)
        {
            webApplication.MapGroup("api/categories").CreateCategoryGroupItemEndpoint();
        }
    }
}
