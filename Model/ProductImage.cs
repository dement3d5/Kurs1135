using System;
using System.Collections.Generic;

namespace WebApplication5.Model
{
    public partial class ProductImage
    {
        public ProductImage()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public byte[] Image { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
