using System;
using System.Collections.Generic;

namespace DatabaseEF.Models
{
    public partial class VehicleInventory
    {
        public int VehicleInventoryId { get; set; }
        public int VehicleOrdersId { get; set; }
        public int OrderId { get; set; }
        public DateTime? ProcessDateTime { get; set; }
        public int OrderLineId { get; set; }
        public string TempVin { get; set; }
        public string VehicleName { get; set; }
        public string VehicleModel { get; set; }
        public int? ApprovedCount { get; set; }
        public DateTime? EstimatedDeliverydate { get; set; }

        public VehicleOrders VehicleOrders { get; set; }
    }
}
