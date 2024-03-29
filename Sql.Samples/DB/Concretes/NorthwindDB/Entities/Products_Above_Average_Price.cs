﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sql.Samples.DB.Concretes.NorthwindDB.Entities
{
    [Keyless]
    public partial class Products_Above_Average_Price
    {
        [StringLength(40)]
        public string ProductName { get; set; } = null!;
        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }
    }
}
