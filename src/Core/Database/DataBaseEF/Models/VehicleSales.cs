using System;
using System.Collections.Generic;

namespace DatabaseEF.Models
{
    public partial class VehicleSales
    {
        public int VehicleSaleId { get; set; }
        public int VehicleLogisticsId { get; set; }
        public string Vin { get; set; }
        public int DistributorId { get; set; }
        public DateTime? SaleDate { get; set; }
        public string SalePrice { get; set; }
        public string Discount { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string PostalCode { get; set; }
        public string ContactNumber { get; set; }

        public VehicleLogistics VehicleLogistics { get; set; }
    }
}
