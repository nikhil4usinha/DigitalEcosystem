using System;
using System.Collections.Generic;

namespace DatabaseEF.Models
{
    public partial class VehicleAccessories
    {
        public int VehicleAccessoriesId { get; set; }
        public int VehicleConfigId { get; set; }
        public int OrderId { get; set; }
        public string TempVin { get; set; }
        public string DealerCode { get; set; }
        public string VehicleName { get; set; }
        public string VehicleModel { get; set; }
        public string CarpetMats { get; set; }
        public string Ledlights { get; set; }
        public string PhoneCableChargePackage { get; set; }

        public VehicleConfig VehicleConfig { get; set; }
    }
}
