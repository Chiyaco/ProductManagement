using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Domain.Common
{
    public interface IAuditEntity
    {
        DateTime CreatedAt { get; set; }

        DateTime ModifiedAt { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

    }
}
