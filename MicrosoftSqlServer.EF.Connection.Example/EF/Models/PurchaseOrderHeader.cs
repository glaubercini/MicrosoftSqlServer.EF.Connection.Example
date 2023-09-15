using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftSqlServer.EF.Connection.Example.EF.Models
{
    internal class PurchaseOrderHeader
    {
        [Key]
        public int PurchaseOrderId { get; set; }

        public int? RevisionNumber { get; set; }

        public int? Status { get; set; }

        public int? EmployeeId { get; set; }

        public int? VendorId { get; set; }

        public int? ShipmethodId { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? ShipDate { get; set; }

        public decimal? SubTotal { get; set; }

        public decimal? TaxAmt { get; set; }

        public decimal? Freight { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
