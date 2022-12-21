

using BigOn.Domain.AppCode.Infrastructure;

namespace BigOn.Domain.Models.Entities
{
    public class ProductImage:BaseEntity
    {
        public string Name { get; set; }    
        public bool isMain { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
