using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Product:BaseEntity<int>
    {
        public string Name { get; set; }=default!;
        public string Description { get; set; } = default!;
        public decimal Price { get; set; }
        
        public string PictureUrl { get; set; }
        public ProductTypes ProductType { get; set; }
        public int ProductTypeId { get; set; }
        public ProductBrand ProductBrand { get; set; }
        public int ProductBrandId { get; set; }



    }
}
