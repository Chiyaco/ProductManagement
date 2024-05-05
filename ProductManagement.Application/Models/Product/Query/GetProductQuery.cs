using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ProductManagement.Application.Models.Product.Query
{
    public class GetProductQuery : IRequest<List<ProductDto>>
    {
    }
}
