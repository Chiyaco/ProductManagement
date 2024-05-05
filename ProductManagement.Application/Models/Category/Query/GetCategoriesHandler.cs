using MediatR;
using ProductManagement.Domain;

namespace ProductManagement.Application.Models.Category.Query
{
    public class GetCategoriesHandler : IRequestHandler<GetCategories, List<Domain.Entities.CategoryType>>
    {
        private readonly IRepository<Domain.Entities.CategoryType> _categoryRepository;

        public GetCategoriesHandler(IRepository<Domain.Entities.CategoryType> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<List<Domain.Entities.CategoryType>> Handle(GetCategories request, CancellationToken cancellationToken)
        {
           var categoriesList = (await _categoryRepository.GetAll()).ToList();

           return categoriesList;
        }
    }
}
