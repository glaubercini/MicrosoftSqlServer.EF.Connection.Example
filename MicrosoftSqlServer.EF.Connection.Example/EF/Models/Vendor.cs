using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftSqlServer.EF.Connection.Example.EF.Models
{
    internal class Vendor
    {
        [Key]
        public int BusinessEntityId { get; set; }

        public string? AccountNumber { get; set; }

        public string? Name { get; set; }

        public byte? CreditRating { get; set; }

        public bool? PreferredVendorStatus { get; set; }

        public bool? ActiveFlag { get; set; }

        public string? PurchasingWebServiceUrl { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
