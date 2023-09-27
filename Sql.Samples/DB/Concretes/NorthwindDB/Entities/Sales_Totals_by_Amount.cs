using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sql.Samples.DB.Concretes.NorthwindDB.Entities
{
    [Keyless]
    public partial class Sales_Totals_by_Amount
    {
        [Column(TypeName = "money")]
        public decimal? SaleAmount { get; set; }
        public int OrderID { get; set; }
        [StringLength(40)]
        public string CompanyName { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? ShippedDate { get; set; }
    }
}
