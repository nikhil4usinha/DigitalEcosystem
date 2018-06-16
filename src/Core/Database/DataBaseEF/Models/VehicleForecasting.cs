using System;
using System.Collections.Generic;

namespace DatabaseEF.Models
{
    public partial class VehicleForecasting
    {
        public int VehicleForecastingId { get; set; }
        public int? VehicleOrdersId { get; set; }
        public int OrderId { get; set; }
        public int DistributorId { get; set; }
        public string DistributorName { get; set; }
        public DateTime? ProcessDateTime { get; set; }
        public int OrderLineId { get; set; }
        public string VehicleName { get; set; }
        public string VehicleModel { get; set; }
        public int EstimatedCount { get; set; }
        public DateTime? EstimatedDeliveryDate { get; set; }

        public VehicleOrders VehicleOrders { get; set; }
    }
}
