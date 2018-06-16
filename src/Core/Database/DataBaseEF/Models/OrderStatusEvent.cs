using System;
using System.Collections.Generic;

namespace DatabaseEF.Models
{
    public partial class OrderStatusEvent
    {
        public int OrderStatusId { get; set; }
        public int VehicleOrdersId { get; set; }
        public int OrderId { get; set; }
        public int DistributorId { get; set; }
        public string OrderStatus { get; set; }
        public DateTime? ProcessDateTime { get; set; }

        public VehicleOrders VehicleOrders { get; set; }
    }
}
