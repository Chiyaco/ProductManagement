using MediatR;

namespace ProductManagement.Application.Models.Category.Query
{
    public class GetCategories : IRequest<List<Domain.Entities.CategoryType>>
    {
    }
}
