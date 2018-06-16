using System;
using System.Collections.Generic;

namespace DatabaseEF.Models
{
    public partial class VehicleLogistics
    {
        public VehicleLogistics()
        {
            VehicleInvoice = new HashSet<VehicleInvoice>();
            VehicleSales = new HashSet<VehicleSales>();
            VehicleStatusEvent = new HashSet<VehicleStatusEvent>();
        }

        public int VehicleLogisticsId { get; set; }
        public int VehicleConfigId { get; set; }
        public int OrderId { get; set; }
        public int DistributorId { get; set; }
        public string VehicleName { get; set; }
        public string VehicleModel { get; set; }
        public string TempVin { get; set; }
        public string Vin { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceAmount { get; set; }

        public VehicleConfig VehicleConfig { get; set; }
        public ICollection<VehicleInvoice> VehicleInvoice { get; set; }
        public ICollection<VehicleSales> VehicleSales { get; set; }
        public ICollection<VehicleStatusEvent> VehicleStatusEvent { get; set; }
    }
}
