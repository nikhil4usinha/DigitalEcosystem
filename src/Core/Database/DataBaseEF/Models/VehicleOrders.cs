using System;
using System.Collections.Generic;

namespace DatabaseEF.Models
{
    public partial class VehicleOrders
    {
        public VehicleOrders()
        {
            OrderStatusEvent = new HashSet<OrderStatusEvent>();
            VehicleConfig = new HashSet<VehicleConfig>();
            VehicleForecasting = new HashSet<VehicleForecasting>();
            VehicleInventory = new HashSet<VehicleInventory>();
        }

        public int VehicleOrdersId { get; set; }
        public int OrderId { get; set; }
        public int DistributorId { get; set; }
        public string DistributorName { get; set; }
        public DateTime? ProcessDateTime { get; set; }
        public int OrderLineId { get; set; }
        public string VehicleName { get; set; }
        public string VehicleModel { get; set; }
        public int EstimatedCount { get; set; }
        public DateTime? EstimatedDeliveryDate { get; set; }

        public ICollection<OrderStatusEvent> OrderStatusEvent { get; set; }
        public ICollection<VehicleConfig> VehicleConfig { get; set; }
        public ICollection<VehicleForecasting> VehicleForecasting { get; set; }
        public ICollection<VehicleInventory> VehicleInventory { get; set; }
    }
}
