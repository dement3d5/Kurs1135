using System;
using System.Collections.Generic;

namespace WebApplication5.Model
{
    public partial class Order
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public DateTime CreateAt { get; set; }
        public int UserId { get; set; }

        public virtual OrderStatus Status { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
