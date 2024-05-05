
using ProductManagement.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;
using ProductManagement.Domain.Enums;

namespace ProductManagement.Domain.Entities
{
    public class Product : BaseEntity, IAuditEntity
    {
        
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public virtual CategoryType? Category { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ModifiedAt { get; set; }
    }
}
