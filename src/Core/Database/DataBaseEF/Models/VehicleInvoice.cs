using System;
using System.Collections.Generic;

namespace DatabaseEF.Models
{
    public partial class VehicleInvoice
    {
        public int VehicleInvoiceId { get; set; }
        public int VehicleLogisticsId { get; set; }
        public int OrderId { get; set; }
        public int DistributorId { get; set; }
        public string VehicleName { get; set; }
        public string VehicleModel { get; set; }
        public string TempVin { get; set; }
        public string Vin { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string VehiclePrice { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceAmount { get; set; }

        public VehicleLogistics VehicleLogistics { get; set; }
    }
}
