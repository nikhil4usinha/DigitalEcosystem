using System;
using System.Collections.Generic;

namespace DatabaseEF.Models
{
    public partial class VehicleStatusEvent
    {
        public int VehicleStatusId { get; set; }
        public int VehicleLogisticsId { get; set; }
        public int OrderId { get; set; }
        public int DistributorId { get; set; }
        public string Vin { get; set; }
        public string Vinstatus { get; set; }

        public VehicleLogistics VehicleLogistics { get; set; }
    }
}
