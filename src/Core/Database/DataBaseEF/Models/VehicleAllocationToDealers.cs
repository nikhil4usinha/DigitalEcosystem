using System;
using System.Collections.Generic;

namespace DatabaseEF.Models
{
    public partial class VehicleAllocationToDealers
    {
        public int VehicleAllocationId { get; set; }
        public int VehicleConfigId { get; set; }
        public int OrderId { get; set; }
        public int DistributorId { get; set; }
        public string TempVin { get; set; }
        public string DealerCode { get; set; }
        public string VehicleName { get; set; }
        public string VehicleModel { get; set; }
        public DateTime? EstimatedDeliveryDate { get; set; }

        public VehicleConfig VehicleConfig { get; set; }
    }
}
