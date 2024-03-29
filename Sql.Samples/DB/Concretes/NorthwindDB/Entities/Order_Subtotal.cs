﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sql.Samples.DB.Concretes.NorthwindDB.Entities
{
    [Keyless]
    public partial class Order_Subtotal
    {
        public int OrderID { get; set; }
        [Column(TypeName = "money")]
        public decimal? Subtotal { get; set; }
    }
}
