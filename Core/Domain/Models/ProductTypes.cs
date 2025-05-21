

namespace Domain.Models
{
    public class ProductTypes: BaseEntity<int>
    {
        public string Name { get; set; } = default!;
        
    }
}
