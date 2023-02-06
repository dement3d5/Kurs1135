using System;
using System.Collections.Generic;

namespace WebApplication5.Model
{
    public partial class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; } = null!;
        public string ShortDescription { get; set; } = null!;
        public string ProductCost { get; set; } = null!;
        public int ImageId { get; set; }

        public virtual ProductCategory Category { get; set; } = null!;
        public virtual ProductImage Image { get; set; } = null!;
    }
}
