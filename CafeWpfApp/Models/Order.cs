using System;
using System.Collections.Generic;
using System.Linq;

namespace CafeWpfApp
{
    public partial class Order
    {
        public Order()
        {
            DishInOrders = new HashSet<DishInOrder>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime DateCreate { get; set; }
        public int StatusOrderId { get; set; }
        public virtual StatusOrder StatusOrder { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public virtual ICollection<DishInOrder> DishInOrders { get; set; }
    }
}
