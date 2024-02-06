﻿namespace ContosoPizza.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPalced { get; set; }
        public DateTime? OrderFulfilled { get; set; }
            public int CustomerId { get; set; }

        public Customer Customer { get; set; } = null!;
        public ICollection<OrderDetail> OrderDetails { get; set; } = null!;


    }
}