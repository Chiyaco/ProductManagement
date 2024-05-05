using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagement.Domain.Common;

namespace ProductManagement.Domain.Entities
{
    public class CategoryType : BaseEntity
    {
        public string CategoryName { get; set; }
    }
}
