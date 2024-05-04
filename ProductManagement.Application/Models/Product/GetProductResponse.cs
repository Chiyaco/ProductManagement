using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Application.Models.Product
{
    public class GetProductResponse : BaseResponseModel
    {
        public List<Domain.Entities.Product> Products { get; set; } = new List<Domain.Entities.Product>();
    }
}
