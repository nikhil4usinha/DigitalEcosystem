using System;
using System.Collections.Generic;

namespace DatabaseEF.Models
{
    public partial class VehicleConfig
    {
        public VehicleConfig()
        {
            DealerVehicleAcceptStatusEvent = new HashSet<DealerVehicleAcceptStatusEvent>();
            VehicleAccessories = new HashSet<VehicleAccessories>();
            VehicleAllocationToDealers = new HashSet<VehicleAllocationToDealers>();
            VehicleLogistics = new HashSet<VehicleLogistics>();
        }

        public int VehicleConfigId { get; set; }
        public int VehicleOrdersId { get; set; }
        public int OrderId { get; set; }
        public string TempVinid { get; set; }
        public DateTime? ProcessDateTime { get; set; }
        public int OrderLineId { get; set; }
        public string VehicleName { get; set; }
        public string VehicleModel { get; set; }
        public int? ApprovedCount { get; set; }
        public DateTime? EstimatedDeliverydate { get; set; }

        public VehicleOrders VehicleOrders { get; set; }
        public ICollection<DealerVehicleAcceptStatusEvent> DealerVehicleAcceptStatusEvent { get; set; }
        public ICollection<VehicleAccessories> VehicleAccessories { get; set; }
        public ICollection<VehicleAllocationToDealers> VehicleAllocationToDealers { get; set; }
        public ICollection<VehicleLogistics> VehicleLogistics { get; set; }
    }
}
