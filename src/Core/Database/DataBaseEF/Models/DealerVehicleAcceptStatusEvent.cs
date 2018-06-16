using System;
using System.Collections.Generic;

namespace DatabaseEF.Models
{
    public partial class DealerVehicleAcceptStatusEvent
    {
        public int DealerVehicleStatusId { get; set; }
        public int VehicleConfigId { get; set; }
        public int OrderId { get; set; }
        public string DealerCode { get; set; }
        public string TempVin { get; set; }
        public string VehicleStatus { get; set; }

        public VehicleConfig VehicleConfig { get; set; }
    }
}
